using System;

namespace MaximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Generic generic = new Generic();
            generic.Compare<int>(66,63,44);
            Console.ReadLine();

            generic.Compare<float>(66.4f, 69.5f, 44.3f);
            Console.ReadLine();

            generic.Compare<string>("Apple", "Banana", "Peach");
            Console.ReadLine();


        }
    }
}
