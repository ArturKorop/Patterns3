using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Factory
{
    [RunAttribute(true, 4)]
    public class Factory : IRunner
    {
        public void Run()
        {
            PizzaStore factory = new NYStylePizzaStore();
            factory.OrderPizza(Pizzas.Veggie);

            factory = new ChicagoStylePizzaStore();
            factory.OrderPizza(Pizzas.Cheese);
        }
    }
}
