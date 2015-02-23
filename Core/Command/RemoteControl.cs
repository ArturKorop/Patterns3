using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Core.Command
{
    public class RemoteControl
    {
        public Tuple<ICommand, ICommand>[] Commands = new Tuple<ICommand,ICommand>[7];

        public void SetCommand(int number, ICommand onCommand, ICommand offCommand)
        {
            this.Commands[number] = new Tuple<ICommand, ICommand>(onCommand, offCommand);
        }

        public void PushOn(int number)
        {
            this.Commands[number].Item1.Execute();
        }

        public void PushOff(int number)
        {
            this.Commands[number].Item2.Execute();
        }
    }
}
