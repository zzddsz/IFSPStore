using IFSPStore.Domain.Entities;
using IFSPStore.Repository.Context;
using IFSPStore.Repository.Repository;
using System.Text.Json;

namespace IFSPStore.Test
{
    [TestClass]
    public sealed class RepositoryTest
    {
        [TestMethod]
        public void TestCategory()
        {
            /*
            using (var context = new IFSPStoreContext())
            {
                Console.WriteLine("Connected!");

                var category1 = new Category(1, "Carnes");
                var category2 = new Category(2, "Bebidas");
                var category3 = new Category(3, "Doces");

                context.Categories.Add(category1);
                context.Categories.Add(category2);
                context.Categories.Add(category3);
                context.SaveChanges();
                Console.WriteLine("Insert done!");


            }

            using (var context = new IFSPStoreContext())
            {
                foreach (var category in context.Categories)
                {
                    Console.WriteLine(JsonSerializer.Serialize(category));
                }
                Console.WriteLine("List done!");
            }
            */
        }

        [TestMethod]
        public void TestProduct()
        {
            var context = new IFSPStoreContext();
            var _categoryRepository = new BaseRepository<Category>(context);
            var _productRepository = new BaseRepository<Product>(context);

            var category1 = new Category();
            category1.Name = "Laticínios";
            _categoryRepository.Insert(category1);
            var catergory2 = new Category();
            catergory2.Name = "Saudáveis";
            _categoryRepository.Insert(catergory2);

            var product1 = new Product();
            product1.Name = "Sardinha";
            product1.Price = 7.90M;
            product1.Quantity = 50;
            product1.PurchaseDate = DateTime.Now;
            product1.SalesUnit = "Lata";
            product1.Category = category1;
            _productRepository.Insert(product1);

            var product2 = new Product();
            product2.Name = "Granola";
            product2.Price = 12.50M;
            product2.Quantity = 30;
            product2.PurchaseDate = DateTime.Now;
            product2.SalesUnit = "Pacote";
            product2.Category = catergory2;
            _productRepository.Insert(product2);
        }

    }
}