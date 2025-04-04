using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Marchandise> marchandises = new List<Marchandise>();
            {
                new Product { Name = "Молоко", Price = 100, Productiondate = new DateTime(14, 02, 2024), Shelflife = 7 };
                new Party { Name = "Яблоки", Price = 200, Count = 10, Productiondate = new DateTime(09, 02, 2024), Shelflife = 30 };
                new Kit { Name = "Подарочный набор", Price = 500, Listproduct = new List };
            }
        }
    }
}
