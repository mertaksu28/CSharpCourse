using System;

namespace Constractors
{
    class Program
    {
        //Constractor
        // Bir Class' new lediğimiz zaman çalışan bloktur.
        // Method mantığı ile çalışırlar.
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, FirstName = "Engin", LastName = "Demiroğ", City = "Ankara" };
        }
    }

    class Customer
    {

        public Customer()
        {
            Console.WriteLine("Yapıcı Blok çalıştı");
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
