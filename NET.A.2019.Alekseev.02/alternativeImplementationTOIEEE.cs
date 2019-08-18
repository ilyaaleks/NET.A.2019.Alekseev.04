using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.A._2019.Alekseev._02.Properties
{
    //private class AlternativeImplementationTOIEEE
    //{
    //    public static string DoubleToBinaryString(this double number)
    //    {

    //        string result = "";
    //        string[] nums = number.ToString("F").Split(',');
    //        if (Double.IsNegativeInfinity(number) == true)
    //        {
    //            result += '1';
    //        }
    //        else
    //        {
    //            result += '0';
    //        }

    //        string intPart = IntToBinaryFormat(nums[0]);
    //        string fractionalPart = FractionalToBinaryFormat(nums[1], 52 - intPart.Length + 1);
    //        string concatResult = intPart + fractionalPart;
    //        int power = intPart.Length - 1;
    //        int offset = 1023 + power;

    //        result += IntToBinaryFormat(offset.ToString()) + concatResult.Substring(1, concatResult.Length - 1);
    //        return result;
    //    }
    //    private static string IntToBinaryFormat(string number)
    //    {
    //        if (number[0] == '-')
    //        {
    //            number = number.Remove(0, 1);
    //        }
    //        double intPart = Convert.ToDouble(number);
    //        string intPartStr = "";
    //        while (intPart > 1)
    //        {
    //            if (intPart % 2 == 1)
    //            {
    //                intPartStr += "1";
    //            }
    //            else
    //            {
    //                intPartStr += "0";
    //            }
    //            intPart = Math.Ceiling(intPart / 2);
    //        }
    //        char[] a = intPartStr.ToCharArray();
    //        Array.Reverse(a);
    //        return new string(a);
    //    }
    //    private static string FractionalToBinaryFormat(string number, int precision)
    //    {
    //        number = "0," + number;

    //        double FractionalPart = Convert.ToDouble(number);

    //        string FractionalPartStr = "";
    //        int count = 0;
    //        while (count != precision)
    //        {
    //            FractionalPart *= 2;

    //            if (FractionalPart >= 1)
    //            {
    //                FractionalPartStr = FractionalPartStr + "1";
    //                number = FractionalPart.ToString();
    //                number = number.Remove(0, 1);
    //                number = number.Insert(0, "0");
    //                FractionalPart = Convert.ToDouble(number);

    //            }
    //            else
    //            {
    //                FractionalPartStr += "0";
    //            }


    //            count++;
    //        }

    //        return FractionalPartStr;
    //    }
    //}
}
