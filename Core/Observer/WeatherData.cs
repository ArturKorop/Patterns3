using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Core.Observer
{
    public class WeatherData : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private Timer timer = new Timer();

        public WeatherData()
        {
            timer.Interval = 1000;
            timer.Elapsed += (e, o) => 
            {
                this.NotifyObserver();
            };

            timer.Start();
        }

        public float Temperature
        {
            get
            {
                var rand = new Random();

                return rand.Next(-30, 30);
            }
        }

        public float Humidity
        {
            get
            {
                var rand = new Random();

                return rand.Next(0, 100);
            }
        }

        public float Pressure
        {
            get
            {
                var rand = new Random();

                return rand.Next(100, 500);
            }
        }

        public void RegisterObserver(IObserver o)
        {
            this.observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            this.observers.Remove(o);
        }

        public void NotifyObserver()
        {
            observers.ForEach(x => x.Update(this.Temperature, this.Humidity, this.Pressure));
        }
    }
}
