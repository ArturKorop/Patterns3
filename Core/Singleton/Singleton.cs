using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Singleton
{
    [RunAttribute(true, 5)]
    public class Singleton : IRunner
    {
        public void Run()
        {
            Task.Run(() => { 
                ChocolateBoiler.Instance.Fill();
                ChocolateBoiler.Instance.Drain();
            });
            Task.Run(() => { 
                ChocolateBoiler.Instance.Fill();
                ChocolateBoiler.Instance.Drain();
            });
        }
    }
}
