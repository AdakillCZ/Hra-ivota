using System;

namespace Hra_Života
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            for (int i = 0; i < 25; i++)
            {
                int rnd = random.Next(2);
                Console.WriteLine(rnd);
            } 
        }
    }
}
