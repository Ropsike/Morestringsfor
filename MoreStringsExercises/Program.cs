using System;

namespace AnotherStringToReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloW = "Basjonks";
            for (int i = helloW.Length - 1; i >= 0; i--)
            {
                Console.Write(helloW[i]);
            }


        }
    }
}