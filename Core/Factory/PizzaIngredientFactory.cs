using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Factory
{
    public interface IPizzaIngredientFactory
    {
        IDough CreateDough();
        ISauce CreateSauce();
        ICheese CreateCheese();
        IVeggie[] CreateVeggies();
    }

    public class NyPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public ICheese CreateCheese()
        {
            return new Mozzarella();
        }

        public IVeggie[] CreateVeggies()
        {
            return new IVeggie[] { new Tomato(), new Potato() };
        }
    }

    public class ChPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThickCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new SlicedPepperoneSause();
        }

        public ICheese CreateCheese()
        {
            return new OtherCheese();
        }

        public IVeggie[] CreateVeggies()
        {
            return new IVeggie[] { new FrozenClams() };
        }
    }

    public interface IDough { }


    public class ThinCrustDough: IDough
    {

    }

    public class ThickCrustDough : IDough
    {
        
    }

    public interface ISauce { }

    public class PlumTomatoSauce : ISauce { }

    public class SlicedPepperoneSause : ISauce { }

    public interface ICheese { }

    public class Mozzarella : ICheese { }

    public class OtherCheese : ICheese {}

    public interface IVeggie { }

    public class FrozenClams : IVeggie { }

    public class Potato : IVeggie { }
    
    public class Tomato : IVeggie { }
}
