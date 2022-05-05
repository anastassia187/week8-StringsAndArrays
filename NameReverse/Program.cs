using System;

namespace NameReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prilozenie sprawivaet u polzovatelja ego imja i pokazivaet ego zadom napered


             Console.WriteLine("Enter your name:");
            string Name = Console.ReadLine();
           

            for(int i = Name.Length - 1; i >=0; i--)
            {
                Console.WriteLine(Name[i]);
            }

            
        }
    }
}
