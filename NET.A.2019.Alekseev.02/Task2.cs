using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.A._2019.Alekseev._02
{
    public static class Task2
    {
        /// <summary>
        /// Implementing binary conversion using bit converter
        /// </summary>
        /// <param name="db">Double value</param>
        /// <returns>String in binary format</returns>
        public static string DoubleToBinaryString(this double db)
        {
            BitArray bitArray = new BitArray(BitConverter.GetBytes(db));
            StringBuilder res = new StringBuilder(64);

            for (int i = bitArray.Length - 1; i >= 0; i--)
            {
                if (bitArray[i] == false)
                    res.Append('0');
                else
                    res.Append('1');
            }

            return res.ToString();
        }
    }
}
