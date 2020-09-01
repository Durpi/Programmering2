using System;
using System.IO;

namespace Programmering2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // File.WriteAllText("words.txt", "Thing");

            // string s = File.ReadAllText("words.txt");

            // Console.WriteLine(s);

            // string[] words = {"Hat", "Coat", "Pants"};

            if (File.Exists("words.txt"))
            {
            string[] words = File.ReadAllLines("words.txt");

            Console.WriteLine(words[0]);

            }            



            // File.WriteAllLines("words.txt", words);

            Console.ReadLine();



        }
    }
}
