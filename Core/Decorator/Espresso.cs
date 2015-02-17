using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Decorator
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            this.Description = "Espresso";
            this.Cost = 20;
        }
    }
}
