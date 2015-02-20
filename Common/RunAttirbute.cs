using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [AttributeUsage(AttributeTargets.Class)]
    public class RunAttribute : Attribute
    {
        public bool Use { get; set; }

        public int Priority { get; set; }

        public RunAttribute(bool use = false, int priority = 0)
        {
            this.Use = use;
            this.Priority = priority;
        }
    }
}
