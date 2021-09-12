using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Ürün Eklendi : " + product.ProductName);
        }
    }
}
