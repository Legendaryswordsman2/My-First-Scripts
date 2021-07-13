using System;

namespace My_Awesome_Program_2
{
    class Wizard
    {
       string name;
       string favouriteSpell;
       int spellSlots;
       float experience;

       public Wizard(string _name, string _favouriteSpell)
       {
           favouriteSpell = _favouriteSpell;
           name = _name;
            spellSlots = 2;
            experience = 0;
       }

       public void CastSpell()
       {
           if (spellSlots > 0)
           {
              Console.WriteLine(name + " casts " + favouriteSpell);
              spellSlots--;
              experience+=0.3f;
           }
           else{
               Console.WriteLine(name + " is out of spell slots.");
           }

       }

       public void Meditate()
       {
           Console.WriteLine(name + " meditates to regain spell slots");
           spellSlots += 2;
       }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Wizard wizard01 = new Wizard("Perry Hopper", "Unexpecto Patronum");

             wizard01.CastSpell();

             Wizard wizard02 = new Wizard("Glindalf Merlinson", "Abracadabra");

             wizard02.CastSpell();

           // Wait Before Closing
           Console.ReadKey();
        }
    }
}
