using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionTest
{
    public class Drink1 : IDrink
    {
        public void PrepareDrink()
        {
            Console.WriteLine("The barman makes a Type 1 Drink");
        }
    }
}
