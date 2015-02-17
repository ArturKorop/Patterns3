using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Decorator
{
    public class HouseBlend : Beverage
    {
        public HouseBlend(Size size) : base(size)
        {
            this.TextDescription = "House blend";
            this.SetCost(30, 25, 20, size);
        }
    }
}
