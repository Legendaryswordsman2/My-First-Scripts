using System;

namespace My_Awesome_Program_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("4 + 8 = ");
            int prob1 = Convert.ToInt32(Console.ReadLine());

            if (prob1 == 12)
            {
                Console.WriteLine("Correct!");
            }
            else {
                Console.WriteLine("Inccorect!");
            }

            Console.Write("6 * 100 = ");
            int prob2 = Convert.ToInt32(Console.ReadLine());

            if (prob2 == 600)
            {
                Console.WriteLine("Correct!");
            }
            else {
                Console.WriteLine("Inccorect!");
            }
            

           // Wait Before Closing
           Console.ReadKey();
        }
    }
}
