using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Command
{
    [RunAttribute(true, 6)]
    public class Command : IRunner
    {
        public void Run()
        {
            var control = new RemoteControl();
            var light = new Light();
            control.SetCommand(0, new LightOnCommand(light), new LightOffCommand(light));

            control.PushOn(0);
        }
    }
}
