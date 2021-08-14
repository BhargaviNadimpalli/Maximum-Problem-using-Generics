using System;

namespace MaximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Generic<int> generic = new Generic<int>();
            generic.Compare(66,63,44);

            Generic<float> generic1 = new Generic<float>();
            generic1.Compare(66.4f, 69.5f, 44.3f);

            Generic<string> generic2 = new Generic<string>();
            generic2.Compare("Apple", "Banana", "Peach");
            Console.ReadLine();


        }
    }
}
