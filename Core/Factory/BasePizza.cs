using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Core.Factory
{
    public abstract class BasePizza : IPizza
    {
        protected IPizzaIngredientFactory factory;

        public BasePizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.factory = ingredientFactory;
        }

        public virtual void Prepare()
        {
            this.factory.CreateCheese().GetType().Name.ToString().P();
            foreach (var item in this.factory.CreateVeggies())
            {
                item.GetType().Name.ToString().P();
            }
            
            this.factory.CreateSauce().GetType().Name.ToString().P();
            this.factory.CreateDough().GetType().Name.ToString().P();
        }

        public virtual void Bake()
        {
            "Bake".P();
        }

        public void Cut()
        {
            "8-piece cut".P();
        }

        public void Box()
        {
            "Boxing".P();
        }
    }
}
