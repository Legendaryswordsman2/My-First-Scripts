using System;

namespace My_Awesome_Program_2
{
    class Program
    {
        static void Main(string[] args)
        {
             MeetAlien();
             MeetAlien();
             MeetAlien();
             MeetAlien();

           // Wait Before Closing
           Console.ReadKey();
        }
        static void MeetAlien() 
        {
            Random numberGen = new Random();

            string name = "X-" + numberGen.Next(10, 9999);
            int age = numberGen.Next(10, 500);

            Console.WriteLine("Hi, I'm " + name + ".\nI'm " + age + " years old.\nOh, and I'm an alien.\n---------------");
        }
    }
}
