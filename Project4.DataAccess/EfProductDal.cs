using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.DataAccess
{
    public class EfProductDal : IProductDal
    {

        //List<Product> _products;

        public EfProductDal()
        {
            //_products = new List<Product>
            //{
            //    new Product{ProductId=1, ProductName="Acer ef Bilgisayar", QuantityPerUnit="32 GB Ram", UnitPrice=10000, UnitsInStock=2},
            //    new Product{ProductId=1, ProductName="Asus ef Bilgisayar", QuantityPerUnit="32 GB Ram", UnitPrice=10000, UnitsInStock=1},
            //    new Product{ProductId=1, ProductName="Hp ef Bilgisayar", QuantityPerUnit="32 GB Ram", UnitPrice=10000, UnitsInStock=0},
            //    new Product{ProductId=1, ProductName="Mac ef Bilgisayar", QuantityPerUnit="32 GB Ram", UnitPrice=10000, UnitsInStock=3},
            //    new Product{ProductId=1, ProductName="Dell ef Bilgisayar", QuantityPerUnit="32 GB Ram", UnitPrice=10000, UnitsInStock=10}
            //};
        }
        public void Add(Product product)
        {
            using (NorthwindContext northwindContext = new NorthwindContext())
            {
                northwindContext.Products.Add(product);
                northwindContext.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (NorthwindContext northwindContext = new NorthwindContext())
            {
                northwindContext.Products.Remove(northwindContext.Products.SingleOrDefault(p => p.ProductId == product.ProductId));
                northwindContext.SaveChanges();
            }
        }

        public List<Product> GetAll()
        {
            using (NorthwindContext northwindContext = new NorthwindContext())
            {
                return northwindContext.Products.ToList();
            }

        }

        public Product GetById(int id)
        {
            using (NorthwindContext northwindContext = new NorthwindContext())
            {
                return northwindContext.Products.SingleOrDefault(p => p.ProductId == id);
            }
        }

        public void Update(Product product)
        {
            using (NorthwindContext northwindContext = new NorthwindContext())
            {
                var productToUpdate = northwindContext.Products.SingleOrDefault(p => p.ProductId == product.ProductId);
                productToUpdate.ProductName = product.ProductName;
                productToUpdate.QuantityPerUnit = product.QuantityPerUnit;
                productToUpdate.UnitPrice = product.UnitPrice;
                productToUpdate.UnitsInStock = product.UnitsInStock;
                productToUpdate.CategoryId = product.CategoryId;  

                northwindContext.SaveChanges();
            }

        }
    }
}
