using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Factory
{
    public class SimplePizzaFactory
    {
        public IPizza CreatePizza(Pizzas type)
        {
            IPizza pizza = null;

            switch(type)
            {
                case Pizzas.Cheese:
                    break;
                case Pizzas.Clam:
                    break;
                case Pizzas.Pepperoni:
                    break;
                case Pizzas.Veggie:
                    break;
            }

            return pizza;
        }
    }

    public enum Pizzas
    {
        Cheese,
        Pepperoni,
        Veggie,
        Clam
    }
}
