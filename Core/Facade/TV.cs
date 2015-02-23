using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Core.Facade
{
    public class TV
    {
        public void On()
        {
            "TV on".P();
        }

        public void Off()
        {
            "TV off".P();
        }
    }

    public class Fan
    {
        public void On()
        {
            "Fan on".P();
        }

        public void Off()
        {
            "Fan off".P();
        }
    }

    public class Tuner
    {
        public void On()
        {
            "Tuner on".P();
        }

        public void Off()
        {
            "Tuner off".P();
        }
    }
}
