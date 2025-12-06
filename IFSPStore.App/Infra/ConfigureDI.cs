using AutoMapper;
using IFSPStore.App.Others;
using IFSPStore.App.Register;
using IFSPStore.App.ViewModel;
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

            services.AddScoped<IBaseRepository<Category>, BaseRepository<Category>>();
            services.AddScoped<IBaseRepository<City>, BaseRepository<City>>();
            services.AddScoped<IBaseRepository<Costumer>, BaseRepository<Costumer>>();
            services.AddScoped<IBaseRepository<Product>, BaseRepository<Product>>();
            services.AddScoped<IBaseRepository<Sale>, BaseRepository<Sale>>();
            services.AddScoped<IBaseRepository<User>, BaseRepository<User>>();
            services.AddScoped<IBaseRepository<SaleItem>, BaseRepository<SaleItem>>();

            services.AddScoped<IBaseService<Category>, BaseService<Category>>();
            services.AddScoped<IBaseService<City>, BaseService<City>>();
            services.AddScoped<IBaseService<Costumer>, BaseService<Costumer>>();
            services.AddScoped<IBaseService<Product>, BaseService<Product>>();
            services.AddScoped<IBaseService<Sale>, BaseService<Sale>>();
            services.AddScoped<IBaseService<User>, BaseService<User>>();
            services.AddScoped<IBaseService<SaleItem>, BaseService<SaleItem>>();

            services.AddTransient<LoginForm>();
            services.AddTransient<CategoryForm>();
            services.AddTransient<CityForm>();
            services.AddTransient<UserForm>();
            services.AddTransient<ProductForm>();
            services.AddTransient<CostumerForm>();
            services.AddTransient<SaleForm>();

            services.AddSingleton(
                new MapperConfiguration(config =>
                {
                    config.CreateMap<User, UserViewModel>();

                    config.CreateMap<Category, CategoryViewModel>();

                    config.CreateMap<City, CityViewModel>()
                        .ForMember(d => d.NameState, o => o.MapFrom(s => $"{s.Name}/{s.State}"));

                    config.CreateMap<Costumer, CostumerViewModel>()
                        .ForMember(d => d.City, o => o.MapFrom(s => $"{s.City.Name}/{s.City.State}")) 
                        .ForMember(d => d.IdCity, o => o.MapFrom(s => s.City.Id)); 

                    config.CreateMap<Product, ProductViewModel>()
                        .ForMember(d => d.Category, o => o.MapFrom(s => s.Category.Name)) 
                        .ForMember(d => d.IdCategory, o => o.MapFrom(s => s.Category.Id)) 
                        .ForMember(d => d.PurchaseDate, o => o.MapFrom(s => s.PurchaseDate.ToShortDateString()));

                    config.CreateMap<Sale, SaleViewModel>()
                        .ForMember(d => d.Salesman, o => o.MapFrom(s => s.Salesman.Name))   
                        .ForMember(d => d.IdSalesman, o => o.MapFrom(s => s.Salesman.Id))   
                        .ForMember(d => d.Customer, o => o.MapFrom(s => s.Customer.Name))   
                        .ForMember(d => d.IdCustomer, o => o.MapFrom(s => s.Customer.Id));  
                  
                    config.CreateMap<SaleItem, SaleItemViewModel>()
                        .ForMember(d => d.Product, o => o.MapFrom(s => s.Product.Name))     
                        .ForMember(d => d.IdProduct, o => o.MapFrom(s => s.Product.Id));    
                }, NullLoggerFactory.Instance).CreateMapper());

            serviceProvider = services.BuildServiceProvider();
        }
    }
}