using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Core.TemplateMethod
{
    [RunAttribute(true, 9)]
    public class TemplateMethod : IRunner
    {
        public void Run()
        {
            var drinks = new List<CaffeineBeverage> { new Tea(), new Coffee() };
            foreach (var drink in drinks)
            {
                drink.PrepareRecipe();
            }
        }
    }
}
