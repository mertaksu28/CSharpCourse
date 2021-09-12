using Project4.DataAccess;
using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.Business
{
    public class ProductManager
    {
        public List<Product> GetAll()
        {
            ProductDal productDal = new ProductDal();
            return productDal.GetAll();
        }
    }
}
