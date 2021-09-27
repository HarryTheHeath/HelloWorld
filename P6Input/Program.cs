using System;

namespace P6Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oh hai there... what's your name?");

            string input = Console.ReadLine();
            
            Console.WriteLine("Oh wow, you're the first " + input + " that I've ever met! :)");
        }
    }
}
