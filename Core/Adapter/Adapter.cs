using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Adapter
{
    [RunAttribute(true, 7)]
    public class Adapter : IRunner
    {
        public void Run()
        {
            IDuck duck = new MallardDuck();
            ITurkey turkey = new Turkey();

            IDuck turkeyLikeDuck = new TurkeyAdapter(turkey);

            var ducks = new IDuck[] { duck, turkeyLikeDuck };
            foreach (var item in ducks)
            {
                item.Quack();
                item.Fly();
            }
        }
    }
}
