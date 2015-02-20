using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Factory
{
    public abstract class PizzaStore
    {
        public IPizza OrderPizza(Pizzas type)
        {
            var pizza = this.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        protected abstract IPizza CreatePizza(Pizzas type);
    }
}
