using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StormDugeon
{
    abstract class Ability
    {
        public CharacterClass ClassRequired { get; set; }
        public string Decription { get; set; }
        public bool HeroAbility { get; set; }
        public int cost { get; set; }
        
    }
}
