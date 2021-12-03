using System;
using System.Collections.Generic;


namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constructor/Instantiate empty Human
            //Human testHuman = new Human();
            

            //Instantiate Human with string name
            Human testHuman1 = new Human("Nick");
            Console.WriteLine(testHuman1);


            //Instantiate Human object with 5 params
            Human testHuman2 = new Human("Naruto", 4, 1, 3, 100);
            Console.WriteLine(testHuman2);

            
            //Nick attacks Naruto 4 Times >>>> Decrese Naruto's Health
            int NarutoHealth = testHuman1.Attack(testHuman2);
            NarutoHealth = testHuman1.Attack(testHuman2);
            NarutoHealth = testHuman1.Attack(testHuman2);
            
            //print to console Naruto object with updated health
            Console.WriteLine(testHuman2);

            
            //Naruto attacks Nick Twice >>>> Decrease Nick's Health
            int NickHealth = testHuman2.Attack(testHuman1);
            NickHealth = testHuman2.Attack(testHuman1);

             //print to console Nick object with updated health
            Console.WriteLine(testHuman1);
        }
    }
}
