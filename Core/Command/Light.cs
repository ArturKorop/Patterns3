using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Core.Command
{
    public class Light
    {
        public void On()
        {
            "Light on".P();
        }

        public void Off()
        {
            "Light off".P();
        }
    }

    public class LightOnCommand : ICommand
    {
        private Light light;

        public LightOnCommand(Light target)
        {
            this.light = target;
        }

        public void Execute()
        {
            this.light.On();
        }
    }

    public class LightOffCommand : ICommand
    {
        private Light light;
        
        public LightOffCommand(Light target)
        {
            this.light = target;
        }       

        public void Execute()
        {
            this.light.Off();
        }
    }
}
