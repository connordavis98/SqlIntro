using System;
using System.Configuration;
using System.Linq;

namespace SqlIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            var repo = new ProductRepository(connectionString);
            foreach (var prod in repo.GetProducts())
            {
                Console.WriteLine("Product Name:" + prod.Name + "ModifiedDate"+ prod.ModifiedDate.DayOfWeek);
            }

           
            Console.ReadLine();
        }
    }
}
