using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Observer
{
    [RunAttribute(false, 2)]
    public class Observer : IRunner
    {
        public void Run()
        {
            var weatherData = new WeatherData();
            var currentDisplay = new CurrentConditionalDisplay();
            var stat = new StatisticsDisplay();

            weatherData.RegisterObserver(currentDisplay);
            weatherData.RegisterObserver(stat);
        }
    }
}
