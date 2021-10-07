using System;

namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloW = "Hello World";
            int i = 0;
                int wordCounter = 1;
            while (i < helloW.Length);
            {
                if(helloW[i] == ' ')
                {
                    wordCounter++;
                }
                i++;
            }
            Console.WriteLine($"Lauses {helloW} on {wordCounter} sõna");
            Console.ReadLine();

        }
    }
}
