using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Core.Adapter
{
    public interface IDuck
    {
        void Quack();

        void Fly();
    }

    public class MallardDuck : IDuck
    {
        public void Quack()
        {
            "I am mallard duck".P();
        }

        public void Fly()
        {
            "I am flying very well".P();
        }
    }

}
