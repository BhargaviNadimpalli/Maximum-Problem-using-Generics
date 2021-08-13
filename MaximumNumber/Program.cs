using System;

namespace MaximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Maximum programs using generic");
            
            int output = NumberCheck.MaximumNumberCheck(33, 44, 66);
            Console.WriteLine(output);

            double floatoutput = NumberCheck.MaximumFloatNumberCheck(11.2, 33.5, 3.7);
            Console.WriteLine(floatoutput);

            string stringoutput = NumberCheck.MaximumStringIntegerNumber("apple", "banana", "peach");
            Console.WriteLine(stringoutput);

        }
    }
}
