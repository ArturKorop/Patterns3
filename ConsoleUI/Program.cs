using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.LoadFrom("Core.dll");
            List<Tuple<IRunner, int>> runners = new List<Tuple<IRunner, int>>();

            foreach (var type in assembly.GetTypes())
            {
                var runnerType = type.GetInterface(typeof(IRunner).Name);
                if(runnerType != null)
                {
                    var attr = type.GetCustomAttribute<RunAttribute>();
                    if (attr != null && attr.Use)
                    {
                        var runner = (IRunner)Activator.CreateInstance(type);
                        runners.Add(new Tuple<IRunner, int>(runner, attr.Priority));
                    }
                }
            }

            var onlyRunners = runners.OrderBy(x=>x.Item2).Select(x=>x.Item1);
            foreach (var runner in onlyRunners)
            {
                runner.GetType().Name.P();
                runner.Run();
                Extensions.Border();
            }

            Extensions.Wait();
        }
    }
}
