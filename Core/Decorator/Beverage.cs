using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Decorator
{
    public abstract class Beverage
    {
        protected double Cost { get; set; }

        public virtual string Description { get; set; }

        public virtual double TotalCost()
        {
            return this.Cost;
        }
    }
}
