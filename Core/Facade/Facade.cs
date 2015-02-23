using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Core.Facade
{
    [RunAttribute(true, 8)]
    public class Facade : IRunner
    {
        public void Run()
        {
            var theatre = new HomeTheatreFacade();
            theatre.WatchFilm();
            theatre.StopFilm();
        }
    }
}
