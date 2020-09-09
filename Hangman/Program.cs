using System;
using System.IO;

namespace Programmering2
{
    class Program
    {
        static void Main(string[] args)
        {

            Random generator = new Random();

            // Console.WriteLine("Hello World!");

            // File.WriteAllText("words.txt", "Thing");

            // string s = File.ReadAllText("words.txt");


            string[] words = {"Hat", "Coat", "Pants", "Dragon", "Computer"};

            File.WriteAllLines("words.txt", words);

            // if (File.Exists("words.txt"))
            // {
            words = File.ReadAllLines("words.txt");

            int randomNumber = generator.Next(5);

            Console.WriteLine(words[randomNumber]);

            // }            



            // File.WriteAllLines("words.txt", words);

            Console.ReadLine();



        }
    }
}
