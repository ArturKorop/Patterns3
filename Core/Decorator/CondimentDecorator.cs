using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Decorator
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage Beverage { get; set; }

        public CondimentDecorator(Beverage beverage) : base(beverage.Size)
        {
            this.Beverage = beverage;
        }

        public override double TotalCost()
        {
            return base.TotalCost() + this.Beverage.TotalCost();
        }

        public override string Description
        {
            get
            {
                return this.Beverage.Description + ", " + base.TextDescription;
            }
        }
    }
}
