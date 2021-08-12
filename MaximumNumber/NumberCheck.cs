using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumNumber
{
    public class NumberCheck
    {
        public static int MaximumNumberCheck(int firstnumber, int secondnumber, int thirdnumber)
        {
            if (firstnumber.CompareTo(secondnumber) > 0 && firstnumber.CompareTo(thirdnumber) > 0) 
            {
                return firstnumber;
            }
            if (secondnumber.CompareTo(firstnumber) > 0 && secondnumber.CompareTo(thirdnumber) > 0) 
            {
                return secondnumber;
            }
            if (thirdnumber.CompareTo(firstnumber) > 0 && thirdnumber.CompareTo(secondnumber) > 0)
            {
                return thirdnumber;
            }
            throw new Exception("firstnumber,secondnumber,thirdnumber are same");
        }
    }

}

