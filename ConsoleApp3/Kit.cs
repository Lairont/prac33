using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Kit : Marchandise
    {
        List<Kit> listproducts;
        public Kit(string name, double price, List<Kit> listproducts) : base(name, price)
        {
            this.Listproducts = listproducts;
        }
        internal List<Kit> Listproducts { get => listproducts; set => listproducts = value; }
        public override void Info()
        {
            Console.WriteLine($"Название {Name}\nЦена {Price}\nПродукты:{Listproducts} ");
        }
        public override bool DeadlineExpirationDate()
        {
            return true;
        } 
    }
}
