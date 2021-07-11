using System;

namespace My_Awesome_Program_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many cool numbers do you want: ");
            double count = Convert.ToDouble(Console.ReadLine());

            for (double i = 1; i <= count; i++)
            {
                double result = Math.Pow(2, i);
                Console.WriteLine(result);
            }

           // Wait Before Closing
           Console.ReadKey();
        }
    }
}
