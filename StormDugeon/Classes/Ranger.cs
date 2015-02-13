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
            availableAbilities = getAvaiableAbilities("StormDugeon.Abilites.RangerAbilites");
        }

        public new void SetAbilites()
        {
           this.StartingAbilities.Add(availableAbilities.ElementAt(0));
        }//will randomize starting abiltiies

    }
}
