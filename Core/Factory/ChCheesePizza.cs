using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Core.Factory
{
    public class ChCheesePizza : BasePizza
    {
        public ChCheesePizza(IPizzaIngredientFactory factory) : base(factory) { }
        public override void Prepare()
        {
            base.Prepare();
            "Chicakge Cheese pizza prepraring".P();
        }
    } 

    public class ChVeggiePizza : BasePizza
    {
        public ChVeggiePizza(IPizzaIngredientFactory factory) : base(factory) { }
        public override void Prepare()
        {
            base.Prepare();
            "Chicago veggie pizza prepraing".P();
        }
    }
}
