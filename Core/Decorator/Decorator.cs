using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Decorator
{
    [RunAttirbute(true, 3)]
    public class Decorator : IRunner
    {
        public void Run()
        {
            Beverage beverage1 = new Espresso();
            beverage1 = new Mocha(beverage1);
            beverage1 = new Milk(beverage1);

            Beverage beverage2 = new HouseBlend();
            beverage2 = new Milk(beverage2);
            beverage2 = new Milk(beverage2);

            "{0} : {1}".PF(beverage1.Description, beverage1.TotalCost());
            "{0} : {1}".PF(beverage2.Description, beverage2.TotalCost());
        }
    }
}
