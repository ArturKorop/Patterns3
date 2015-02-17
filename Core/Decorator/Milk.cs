using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Decorator
{
    public class Milk : CondimentDecorator
    {
        public Milk(Beverage beverage) : base(beverage)
        {
            this.TextDescription = "Milk";
            this.SetCost(5, 4, 3, beverage.Size);
        }
    }
}
