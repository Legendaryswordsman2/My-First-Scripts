using System;

namespace My_Awesome_Program_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numberGen = new Random();

            int roll = 0;
            int roll2 = 1;
            int attempts = 0;

            Console.WriteLine("Press enter to roll the dice");

            while(roll != roll2) {
                 Console.ReadKey();

                 roll = numberGen.Next(1, 7);
                 roll2 = numberGen.Next(1, 7);

                 Console.WriteLine("roll 1: " + roll);
                 Console.WriteLine("roll 2: " + roll2 + "\n");
                 

                 attempts++;
            
            }

             Console.WriteLine("It took " + attempts + " to roll two of a kind.");

           // Wait Before Closing
           Console.ReadKey();
        }
    }
}
