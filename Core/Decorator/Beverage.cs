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

        protected string TextDescription { get; set; }

        public virtual string Description
        {
            get
            {
                return this.Size.ToString() + " " + this.TextDescription;
            }
        }

        public virtual Size Size { get; protected set; }

        public Beverage(Size size)
        {
            this.Size = size;
        }

        public virtual double TotalCost()
        {
            return this.Cost;
        }

        protected void SetCost(double big, double medium, double little, Size size)
        {
            switch (size)
            {
                case Core.Decorator.Size.Big:
                    this.Cost = big;
                    break;
                case Core.Decorator.Size.Medium:
                    this.Cost = medium;
                    break;
                case Core.Decorator.Size.Little:
                    this.Cost = little;
                    break;
            }
        }
    }

    public enum Size
    {
        Little,
        Medium,
        Big
    }
}
