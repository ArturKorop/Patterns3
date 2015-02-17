using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Decorator
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            this.Description = "House blend";
            this.Cost = 30;
        }
    }
}
