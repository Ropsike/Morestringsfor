using System;

namespace CharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonna nimi:");
            string lastName = Console.ReadLine();
            string fullName = $"{firstName} {lastName}";
            int charCounter = 0;
            foreach (char c in fullName)
            {
                charCounter++;
            }
            Console.WriteLine(charCounter);

        }
    }
}
