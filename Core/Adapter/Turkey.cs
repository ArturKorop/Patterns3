using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Core.Adapter
{
    public interface ITurkey
    {
        void Gobble();

        void Fly();
    }

    public class Turkey : ITurkey
    {
        public void Gobble()
        {
            "I am turkey, gobble, gobble".P();
        }

        public void Fly()
        {
            "I am flying really bad, sorry".P();
        }
    }
}
