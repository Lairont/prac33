using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Party : Marchandise
    {
        int count;
        DateTime productiondate;
        int shelflife;

        public Party(string name, double price, int count, DateTime productiondate, int shelflife) : base(name, price)
        {
            this.Productiondate = productiondate;
            this.Shelflife = shelflife;
        }
        public DateTime Productiondate { get => productiondate; set => productiondate = value; }
        public int Shelflife { get => shelflife; set => shelflife = value; }
        public int Count { get => count; set => count = value; }

        public override void Info()
        {
            Console.WriteLine($"Название {Name}\nЦена {Price}\nКоличество {Count}\nДата производства {productiondate}\nСрок годности {Shelflife} ");
        }
        public override bool DeadlineExpirationDate()
        {
            return DateTime.Now < productiondate;
        }
    }
}
