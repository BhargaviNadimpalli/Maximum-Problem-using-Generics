using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumNumber
{
    public class Generic
    {
        public void Compare<T>(T a, T b, T c)     
        {
            dynamic d1 = a;
            dynamic d2 = b;
            dynamic d3 = c;
            if (d1.CompareTo(d2) > 0 && d1.CompareTo(d3) > 0)

                Console.WriteLine("The largest number is : " + d1);

            if (d2.CompareTo(d1) > 0 && d2.CompareTo(d3) > 0)

                Console.WriteLine("The largest number is : " + d2);

            if (d3.CompareTo(d1) > 0 && d3.CompareTo(d2) > 0)

                Console.WriteLine("The largest number is : " + d3);
        }
    }
}
            
            
           
            