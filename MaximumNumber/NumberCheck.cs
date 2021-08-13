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
        public static double MaximumFloatNumberCheck(double firstnumber, double secondnumber, double thirdnumber)
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
        public static string MaximumStringIntegerNumber(string firstvalue, string secondvalue, string thirdvalue)
        {
            if (firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) > 0 || firstvalue.CompareTo(secondvalue) >= 0 && firstvalue.CompareTo(thirdvalue) > 0 || firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) >= 0)
            {
                return firstvalue;

            }
            if (secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) > 0 || secondvalue.CompareTo(firstvalue) >= 0 && secondvalue.CompareTo(thirdvalue) > 0 || secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) >= 0)
            {
                return secondvalue;
            }
            if (thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) > 0 || thirdvalue.CompareTo(firstvalue) >= 0 && thirdvalue.CompareTo(secondvalue) > 0 || thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) >= 0)
            {
                return thirdvalue;
            }
             throw new Exception("firstNumber,SecondNumber,ThirdNumber are same ");
        }

    }
}

