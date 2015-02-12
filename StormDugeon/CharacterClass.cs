using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StormDugeon
{
    interface CharacterClass//should this be a classor an interface?
    {
         string className{ get; set;}
         double Health{ get; set;}
         string model { get; set; }
         int Armour { get; set; }
         double Damage { get; set; }
         int Strength { get; set; }
         int Intellegence { get; set; }
         int Dextreity { get; set; }
         int Survivaiblty { get; set; }
         int Speed { get; set; }
         List<Ability> StartingAbilities { get; set; }
         void RandomizeAbilites();//randomize starting abiltiies
        
    }
}
