using System;

namespace P5Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;

            int numberString;

            Convert.ToString(number);

            numberString = number;
            
            Console.WriteLine("number string = " + numberString);
            

            numberString = (int) 56.3;
            
            number = Convert.ToInt32(numberString);
            
            Console.WriteLine("number = " + number);
        }
    }
}
