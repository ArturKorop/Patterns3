using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Decorator
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage) : base(beverage)
        {
            this.TextDescription = "Mocha";
            this.SetCost(3, 3, 2, beverage.Size);
        }
    }
}
