using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Factory
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        protected override IPizza CreatePizza(Pizzas type)
        {
            IPizzaIngredientFactory factory = new ChPizzaIngredientFactory();
            switch(type)
            {
                case Pizzas.Cheese:
                    return new ChCheesePizza(factory);
                case Pizzas.Veggie:
                    return new ChVeggiePizza(factory);
                default:
                    return null;
            }
        }
    }
}
