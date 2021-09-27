using System;

namespace P7Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = 7 + 5;
            int x = w * 3;
            int y = x - 6;
            int z = y - 5; // should be "y / 1.2" 
            int mod = z % 17;

            Console.WriteLine(mod);
        }
    }
}
