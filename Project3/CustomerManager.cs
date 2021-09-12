using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class CustomerManager
    {
        public CustomerManager()
        {
            customers = new List<Customer>()
            {
                new Customer{Id=1,FirstName="Engin",LastName="Demiroğ",City="Ankara",Email="engin@"},
                new Customer{Id=1,FirstName="Derin",LastName="Demiroğ",City="İstanbul",Email="derin@"},
                new Customer{Id=1,FirstName="Salih",LastName="Demiroğ",City="İzmir",Email="salih@"},
                new Customer{Id=1,FirstName="Ahmet",LastName="Demiroğ",City="Bursa",Email="ahmet@"},
                new Customer{Id=1,FirstName="Mehmet",LastName="Demiroğ",City="Ankara",Email="mehmet@"}
            };
        }
        List<Customer> customers;
        public List<Customer> GetAll()
        {

            return customers;

        }

        public void Add(Customer customer)
        {
            customers.Add(customer);
        }
    }
}
