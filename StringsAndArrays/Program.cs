using System;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //prilozenie prosit polzovatelja vvesti imja i pokazivaet skolko bukv v imeni polzovatelja

            Console.WriteLine("Enter your name:");
            string Name = Console.ReadLine();
            int NameLenght = Name.Length;

            Console.WriteLine($"Your name is {NameLenght} characters long");
        }
    }
}
