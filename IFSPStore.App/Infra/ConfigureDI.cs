using AutoMapper;
using IFSPStore.App.Others; // Para o LoginForm
using IFSPStore.App.Register;
using IFSPStore.App.ViewModel; // Singular, conforme seus arquivos
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Repository.Context;
using IFSPStore.Repository.Repository;
using IFSPStore.Service.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;

namespace IFSPStore.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection services;
        public static IServiceProvider? serviceProvider;

        public static void ConfigureServices()
        {
            // --- Configuração do Banco de Dados ---
            var dbConfigFile = "Config/DBConfig.txt";

            if (!Directory.Exists("Config")) Directory.CreateDirectory("Config");
            if (!File.Exists(dbConfigFile)) File.WriteAllText(dbConfigFile, "Server=localhost;Database=ifspstore;Uid=root;Pwd=admin;");

            var strCon = File.ReadAllText(dbConfigFile);
            services = new ServiceCollection();

            services.AddDbContext<IFSPStoreContext>(options =>
            {
                options.LogTo(Console.WriteLine);
                options.UseMySQL(strCon);
            });

            // ---------------- REPOSITORIES ----------------
            services.AddScoped<IBaseRepository<Category>, BaseRepository<Category>>();
            services.AddScoped<IBaseRepository<City>, BaseRepository<City>>();
            services.AddScoped<IBaseRepository<Costumer>, BaseRepository<Costumer>>(); // Entidade Costumer
            services.AddScoped<IBaseRepository<Product>, BaseRepository<Product>>();
            services.AddScoped<IBaseRepository<Sale>, BaseRepository<Sale>>();
            services.AddScoped<IBaseRepository<User>, BaseRepository<User>>();
            services.AddScoped<IBaseRepository<SaleItem>, BaseRepository<SaleItem>>(); // Adicionado SaleItem

            // ---------------- SERVICES ----------------
            services.AddScoped<IBaseService<Category>, BaseService<Category>>();
            services.AddScoped<IBaseService<City>, BaseService<City>>();
            services.AddScoped<IBaseService<Costumer>, BaseService<Costumer>>();
            services.AddScoped<IBaseService<Product>, BaseService<Product>>();
            services.AddScoped<IBaseService<Sale>, BaseService<Sale>>();
            services.AddScoped<IBaseService<User>, BaseService<User>>();
            services.AddScoped<IBaseService<SaleItem>, BaseService<SaleItem>>();

            // ---------------- FORMS ----------------
            services.AddTransient<LoginForm>();
            services.AddTransient<CategoryForm>();
            services.AddTransient<CityForm>();
            services.AddTransient<UserForm>();
            services.AddTransient<ProductForm>();
            services.AddTransient<CostumerForm>();
            services.AddTransient<SaleForm>();

            // ---------------- AUTOMAPPER (Ajustado para seus arquivos) ----------------
            services.AddSingleton(
                new MapperConfiguration(config =>
                {
                    // User -> UserViewModel
                    config.CreateMap<User, UserViewModel>();

                    // Category -> CategoryViewModel
                    config.CreateMap<Category, CategoryViewModel>();

                    // City -> CityViewModel
                    config.CreateMap<City, CityViewModel>()
                        .ForMember(d => d.NameState, o => o.MapFrom(s => $"{s.Name}/{s.State}"));

                    // Costumer -> CostumerViewModel
                    config.CreateMap<Costumer, CostumerViewModel>()
                        .ForMember(d => d.City, o => o.MapFrom(s => $"{s.City.Name}/{s.City.State}")) // Preenche a string 'City'
                        .ForMember(d => d.IdCity, o => o.MapFrom(s => s.City.Id)); // Preenche o int 'IdCity'

                    // Product -> ProductViewModel
                    config.CreateMap<Product, ProductViewModel>()
                        .ForMember(d => d.Category, o => o.MapFrom(s => s.Category.Name)) // ViewModel: Category (string)
                        .ForMember(d => d.IdCategory, o => o.MapFrom(s => s.Category.Id)) // ViewModel: IdCategory (int)
                        .ForMember(d => d.PurchaseDate, o => o.MapFrom(s => s.PurchaseDate.ToShortDateString())); // Converte DateTime para String

                    // Sale -> SaleViewModel
                    config.CreateMap<Sale, SaleViewModel>()
                        .ForMember(d => d.Salesman, o => o.MapFrom(s => s.Salesman.Name))   // ViewModel: Salesman (string)
                        .ForMember(d => d.IdSalesman, o => o.MapFrom(s => s.Salesman.Id))   // ViewModel: IdSalesman (int)
                        .ForMember(d => d.Customer, o => o.MapFrom(s => s.Costomer.Name))   // ATENÇÃO: Na sua Entidade Sale está escrito 'Costomer'
                        .ForMember(d => d.IdCustomer, o => o.MapFrom(s => s.Costomer.Id));  // ATENÇÃO: Na sua Entidade Sale está escrito 'Costomer'

                    // SaleItem -> SaleItemViewModel
                    config.CreateMap<SaleItem, SaleItemViewModel>()
                        .ForMember(d => d.Product, o => o.MapFrom(s => s.Product.Name))     // ViewModel: Product (string)
                        .ForMember(d => d.IdProduct, o => o.MapFrom(s => s.Product.Id));    // ViewModel: IdProduct (int)

                }, NullLoggerFactory.Instance).CreateMapper());

            serviceProvider = services.BuildServiceProvider();
        }
    }
}