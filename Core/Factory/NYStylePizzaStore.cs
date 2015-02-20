using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Factory
{
    public class NYStylePizzaStore : PizzaStore
    {
        protected override IPizza CreatePizza(Pizzas type)
        {
            IPizzaIngredientFactory factory = new NyPizzaIngredientFactory();
            switch (type)
            {
                case Pizzas.Cheese:
                    return new NYCheesePizza(factory);
                case Pizzas.Veggie:
                    return new NYVeggiePizza(factory);
                default:
                    return null;
            }
        }
    }
}
