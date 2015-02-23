using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Core.Facade
{
    public class HomeTheatreFacade
    {
        private TV tv;
        private Fan fan;
        private Tuner tuner;

        public HomeTheatreFacade()
        {
            this.tv = new TV();
            this.fan = new Fan();
            this.tuner = new Tuner();
        }

        public void WatchFilm()
        {
            this.fan.On();
            this.tuner.On();
            this.tv.On();
        }

        public void StopFilm()
        {
            this.fan.Off();
            this.tuner.Off();
            this.tv.Off();
        }
    }
}
