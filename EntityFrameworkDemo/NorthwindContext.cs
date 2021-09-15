using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    //Context classı dosyası; bizim veritabanı ile uygulamamızdaki nesneler arasındaki ilişkiyi kurduğumuz yerdir.
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=Northwind; Trusted_Connection=True");
        }

        public DbSet<Product> Products { get; set; }

    }
}
