using System;
using System.Linq;

namespace SqlIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Server=localhost;Database=adventureworks;User Id=root;Password = Littlebit11;"; 
            var repo = new ProductRepository(connectionString);
            foreach (var prod in repo.GetProducts().Take(1))
            {
                Console.WriteLine("Product Name:" + prod.Name);
            }

           
            Console.ReadLine();
        }
    }
}
