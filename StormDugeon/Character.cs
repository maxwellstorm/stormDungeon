using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StormDugeon
{
    class Character
    {
        private CharacterClass CharClass;
        private List<Perk> SelectedPerk;
        private List<Ability> SelectedAbilies;
        private List<Perk> LockedPerks;
        private List<Ability> LockedAbilities;
        private string Name;
       

        //equipment
        private Weapon EquippedWeapon;
        private Armour EquippedArmour;

        //stats
        private int Level;
        private double Health;
        private int Armour;
        private double Damage;
        private int Strength;
        private int Intellegence;
        private int Dextreity;
        private int Survivaiblty;
        private int Speed;
        
  

        private const double StrengthDamageModifier = .1;
        private const double SurvivabiltyHealthModifier = .1;


        public void IncreaseStrength()//increses strength by 1
        {
            Strength++;
            Damage = Damage + (Damage * StrengthDamageModifier);
        }

        public void DecreseStrength()//decreses strength by 1
        {
            Strength--;
            Damage = Damage - (Damage * StrengthDamageModifier);
        }


        public void IncreaseSurvivabiltiy()//increses survivabilty by 1
        {
            Survivaiblty++;
            Health = Health + (Health * SurvivabiltyHealthModifier);
        }


        public void DecreaseSurvivabiltiy()//decreases survivabilty by 1
        {
            Survivaiblty--;
            Health = Health - (Health * SurvivabiltyHealthModifier);
        }

        public void IncreaseArmour()
        {
            Armour++;
        }

        public void DecreaseArmour()
        {
            Armour--;
        }


      
   }
}
