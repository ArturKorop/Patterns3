using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Core.Factory
{
    public class NYCheesePizza : BasePizza
    {
        public NYCheesePizza(IPizzaIngredientFactory factory) : base(factory) { }

        public override void Prepare()
        {
            base.Prepare();
            "NY cheese pizza prepare".P();
        }
    }

    public class NYVeggiePizza : BasePizza
    {
        public NYVeggiePizza(IPizzaIngredientFactory factory) : base(factory) { }

        public override void Prepare()
        {
            base.Prepare();
            "NY veggie pizza prepare".P();
        }
    }
}