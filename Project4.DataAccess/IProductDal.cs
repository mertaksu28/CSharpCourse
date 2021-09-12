using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.DataAccess
{
    public interface IProductDal
    {
        List<Product> GetAll();
        void Add(Product product);
    }
}
