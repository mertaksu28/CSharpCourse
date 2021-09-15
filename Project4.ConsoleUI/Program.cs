using Project4.Business;
using Project4.DataAccess;
using Project4.Entities;
using System;

namespace Project4.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            productManager.Add(new Product { ProductName = "Klavye", CategoryId = 1, QuantityPerUnit = "4 ayaklı masa", UnitPrice = 1000, UnitsInStock = 10 });

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
            //try
            //{
            //    productManager.Add(new Product { ProductId = 10, ProductName = "Laptop", QuantityPerUnit = "4 ayaklı masa", UnitPrice = 1000, UnitsInStock = 10 });
            //}
            //catch (DuplicateProductException exception)
            //{

            //    Console.WriteLine(exception.Message);
            //}


        }
    }
}
