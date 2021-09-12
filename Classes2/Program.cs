using System;

namespace Classes2
{
    class Program
    {
        //Reausability: Bir şey yaptığınız zaman onu tekrar tekrar kullanabilmeliyiz. Kendi kendimizi tekrar etmemeliyiz.
        static void Main(string[] args)
        {
            Product product1 = new Product() { ProductName = "Laptop", UnitPrice = 5000, UnitsInStock = 5 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
        }
    }
}
