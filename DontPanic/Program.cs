using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //prilozenie zamenjaet vo fraze K33p C4lm vse simvoly ' 3 na 'e' i vse '4' na 'a'

            string K33pC4lm = "K33p C4lm";


            K33pC4lm = K33pC4lm.Replace('3', 'e');
            K33pC4lm = K33pC4lm.Replace('4', 'a');

            Console.WriteLine(K33pC4lm);
        }
    }
}
