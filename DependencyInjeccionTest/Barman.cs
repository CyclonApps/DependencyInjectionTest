using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionTest
{
    internal class Barman
    {
        IDrink drink;
        public Barman(IDrink drink)
        {
            this.drink = drink;
        }
        
        public void PrepareDrink()
        {
            this.drink.PrepareDrink();
        }
    }
}
