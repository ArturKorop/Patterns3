using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Core.TemplateMethod
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            this.BoilWater();
            this.Brew();
            this.PourInCup();
            this.AddCondiments();
        }

        protected abstract void Brew();

        protected abstract void AddCondiments();

        protected void BoilWater()
        {
            "Boiling water".P();
        }

        protected void PourInCup()
        {
            "Poruing into cup".P();
        }
    }

    public class Tea : CaffeineBeverage
    {
        protected override void Brew()
        {
            "Steeping the tea".P();
        }

        protected override void AddCondiments()
        {
            "Adding lemon".P();
        }
    }

    public class Coffee : CaffeineBeverage
    {
        protected override void Brew()
        {
            "Dripping Coffee through filter".P();
        }

        protected override void AddCondiments()
        {
            "Adding Sugar and Milk".P();
        }
    }

}
