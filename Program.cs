﻿using System;

namespace My_Awesome_Program_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] movies = new string[4];
            Console.WriteLine("type in four words: ");

            for (int i = 0; i < movies.Length; i++)
            {
            movies[i] = Console.ReadLine();
            }

            Console.WriteLine("\nHere they are alphabetically: ");

            Array.Sort(movies);

            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine(movies[i]);
            }

           // Wait Before Closing
           Console.ReadKey();
        }
    }
}
