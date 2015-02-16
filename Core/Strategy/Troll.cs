using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Strategy
{
    public class Troll : BaseCharacter
    {
        public Troll() : base(new AxeBehavior())
        {}
    }
}
