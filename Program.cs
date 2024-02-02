using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Dynamic;
namespace EntityFMWK
{
    internal class Program
    {

        static void Main(string[] args)
        {
           

            using(Connection connection = new Connection())
            {
                var table = connection.Products
                                      .Where(row => row.Name == "Чипсы");
                //connection.RemoveRange(table);
                //connection.SaveChanges();






                //foreach (var product in connection.Products)
                //{
                //    Console.WriteLine($"Название: {product.Name}\n" +
                //                      $"Цена: {product.Price}\n" +
                //                      $"Дата производства: {product.Date}\n" +
                //                      $"Количество {product.Count}\n");
                //}




            //    var table = connection.Products
            //                          .Where(row => row.Name.StartsWith("Чипсы"));
            //    foreach(Product product in table)
            //    {
            //        Console.WriteLine($"Название: {product.Name}\n" +
            //                          $"Цена: {product.Price}\n" +
            //                          $"Дата производства: {product.Date}\n" +
            //                          $"Количество {product.Count}");
            //    }
            }

            //ADD
            Product product = new();
            product.Name = "Кока кола";
            product.Count = 12;
            product.Price = 54.3;
            product.Date = DateTime.Now;
            
            
            
        }
    }
}
