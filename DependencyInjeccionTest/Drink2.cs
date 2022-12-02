using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionTest
{
    internal class Drink2 : IDrink
    {
        string drinkType { get; set; }

        public Drink2(string drinkType)
        {
            this.drinkType = drinkType;
        }

        public void PrepareDrink()
        {
            Console.WriteLine("The barman makes a " + drinkType + " Type 2 Drink");
        }
    }
}
