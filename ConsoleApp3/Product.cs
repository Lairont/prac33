using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Product : Marchandise
    {
        DateTime productiondate;
        int shelflife;

        public Product(string name, double price, DateTime productiondate, int shelflife) : base(name, price)
        {
            this.Productiondate = productiondate;
            this.Shelflife = shelflife;
        }
        public DateTime Productiondate { get => productiondate; set => productiondate = value; }
        public int Shelflife { get => shelflife; set => shelflife = value; }
        public override void Info()
        {
            Console.WriteLine($"Название {Name}\nЦена {Price}\nДата производства {productiondate}\nСрок годности {Shelflife} ");
        }
        public override bool DeadlineExpirationDate()
        {
            return DateTime.Now > productiondate;
        }
    }
}
