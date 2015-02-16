using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Core.Strategy
{
    public class BaseCharacter
    {
        public IWeaponBehavior WeaponBehavior { get; set; }

        public BaseCharacter(IWeaponBehavior weaponBehavior)
        {
            this.WeaponBehavior = weaponBehavior;
        }

        public void Fight()
        {
            this.GetType().Name.P();
            this.WeaponBehavior.UseWeapon();
        }
    }
}
