using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.Entities
{
    public class Personel : IEntity
    {
        public int Id { get; set; }
        public string SurName { get; set; }
        public string Name { get; set; }

    }
}
