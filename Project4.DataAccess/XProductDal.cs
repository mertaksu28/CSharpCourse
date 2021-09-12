using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.DataAccess
{
    public class XProductDal : IProductDal
    {
        List<Product> _products;
        public XProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId=1, ProductName="Acer x Bilgisayar", QuantityPerUnit="32 GB Ram", UnitPrice=10000, UnitsInStock=2},
                new Product{ProductId=1, ProductName="Asus x Bilgisayar", QuantityPerUnit="32 GB Ram", UnitPrice=10000, UnitsInStock=1},
                new Product{ProductId=1, ProductName="Hp x Bilgisayar", QuantityPerUnit="32 GB Ram", UnitPrice=10000, UnitsInStock=0},
                new Product{ProductId=1, ProductName="Mac x Bilgisayar", QuantityPerUnit="32 GB Ram", UnitPrice=10000, UnitsInStock=3},
                new Product{ProductId=1, ProductName="Dell x Bilgisayar", QuantityPerUnit="32 GB Ram", UnitPrice=10000, UnitsInStock=10}
            };
        }

        public void Add(Product product)
        {
            throw new Exception("Veritabanına bağlanılamadı. şifre doğru değil");
            //Console.WriteLine("X ile eklendi");
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
