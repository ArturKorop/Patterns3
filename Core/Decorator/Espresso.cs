using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Decorator
{
    public class Espresso : Beverage
    {
        public Espresso(Size size) : base(size)
        {
            this.TextDescription = "Espresso";
            this.SetCost(20, 15, 10, size);
        }
    }
}
