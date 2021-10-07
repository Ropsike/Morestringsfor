using System;

namespace Supp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi:");
            string lastName = Console.ReadLine();
            string fullName = $"{firstName} {lastName}";

            fullName = fullName.Replace('a', '*');
            Console.WriteLine(fullName);
        }
    }
}
