using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Core.Observer
{
    class CurrentConditionalDisplay : IObserver
    {
        public void Update(float temp, float humidity, float pressure)
        {
            "Current t: {0}".PF(temp);
            "Current h: {0}".PF(humidity);
            "Current p: {0}".PF(pressure);
            "=====".P();
        }
    }
}
