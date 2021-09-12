using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.Entities
{
    public class Customer:IEntity
    {
        public int CustomerId { get; set; }
        public string ContactName { get; set; }
    }
}
