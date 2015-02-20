using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Strategy
{
    [RunAttribute(true, 1)]
    public class Strategy : IRunner
    {
        public void Run()
        {
            List<BaseCharacter> characters = new List<BaseCharacter>();
            characters.Add(new Troll());
            characters.Add(new Knight());

            foreach (var character in characters)
            {
                character.Fight();
            }

            characters.Last().WeaponBehavior = new AxeBehavior();

            foreach (var character in characters)
            {
                character.Fight();
            }
        }
    }
}
