using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StormDugeon.Abilites.RangerAbilites;

namespace StormDugeon.Classes
{
    class Ranger : CharacterClass
    {
        public Ranger()
        {
            className = "Ranger";
            Damage = 3;
            Dextreity = 5;
            Health = 10;
            Intellegence = 1;
            Speed = 5;
            Survivaiblty = 3;
        }

        public new void SetAbilites()
        {
            this.StartingAbilities.Add(new BowStrike());
        }//randomize starting abiltiies

    }
}
