using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumNumber
{
    public class NumberCheck
    {
        public static int MaximumNumberCheck(int firstnumber, int secondnumber, int thirdnumber)
        {
            if (firstnumber.CompareTo(secondnumber) > 0 && firstnumber.CompareTo(thirdnumber)
            {
                return firstnumber;

            }
            if (secondnumber.CompareTo(firstnumber) > 0 && secondnumber.CompareTo(thirdnumber)
            {
                return secondnumber;
            }
            if (thirdnumber.CompareTo(firstnumber) > 0 && thirdnumber.CompareTo(secondnumber) 
            {
                return thirdnumber;
            }
          throw new Exception("firstNumber,SecondNumber,Thirdnumber are same ");

        }
        public static double MaximumFloatNumberCheck(double firstnumber, double secondnumber, double thirdnumber)
        {
            if (firstnumber.CompareTo(secondnumber) > 0 && firstnumber.CompareTo(thirdnumber)
            {
                return firstnumber;

            }
            if (secondnumber.CompareTo(firstnumber) > 0 && secondnumber.CompareTo(thirdnumber) 
            {
                return secondnumber;
            }
            if (thirdnumber.CompareTo(firstnumber) > 0 && thirdnumber.CompareTo(secondnumber)
            {
                return thirdnumber;
            }
            throw new Exception("firstNumber,SecondNumber,Thirdnumber are same ");

        }
    }

}

