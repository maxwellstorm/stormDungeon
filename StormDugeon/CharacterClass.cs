using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StormDugeon.Abilites;
using System.Reflection;
using System.Collections.Generic;

namespace StormDugeon
{
     abstract class CharacterClass//should this be a class or an interface?
    {
         public string className{ get; set;}
         public double Health { get; set; }
         public string model { get; set; }
         public double Damage { get; set; }
         public int Strength { get; set; }
         public int Intellegence { get; set; }
         public int Dextreity { get; set; }
         public int Survivaiblty { get; set; }
         public int Speed { get; set; }
         public List<Ability> StartingAbilities { get; set; }
         public List<Ability> availableAbilities { get; set; }
         public void SetAbilites()
         {
         }//randomize starting abiltiies

         public List<Ability> getAvaiableAbilities(string NamespaceName)
        {
          Assembly asm = Assembly.GetExecutingAssembly();
          List<Ability> abs = new List<Ability>();
          try
          {
              foreach (Type type in asm.GetTypes())
              {
                  if (type.Namespace == NamespaceName)
                      abs.Add((Ability)type.GetConstructor(new Type[] { }).Invoke(new Type[] { }));
              }
          }
          catch (Exception e)
          {
              Console.WriteLine(e.Message);
              return null;
          }
          return abs;

        }
        
    }
}
