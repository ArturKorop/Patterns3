using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Core.Observer
{
    public class StatisticsDisplay : IObserver
    {
        private List<float> totalTemp = new List<float>();
        private List<float> totalHumidity = new List<float>();
        private List<float> totalPressure = new List<float>();

        public void Update(float temp, float humidity, float pressure)
        {
            this.totalTemp.Add(temp);
            this.totalHumidity.Add(humidity);
            this.totalPressure.Add(pressure);

            this.Display(totalTemp, "T");
            this.Display(totalHumidity, "H");
            this.Display(totalPressure, "P");
            "===============".P();
        }

        private void Display(List<float> values, string type)
        {
            "Avg/Min/Max {0} - {1}/{2}/{3}".PF(type, values.Average(), values.Min(), values.Max());
        }
    }

}
