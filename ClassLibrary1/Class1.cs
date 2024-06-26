﻿using System.Collections;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Text;

namespace ClassLibrary1
{
    public class Class1
    {
        /// <summary>
        ///  This method iterates from 1 to the <c>upperBound</c> passed in checking if each number is divisible by the modulators and appending the correspondoing modulator string. 
        ///  If it is not divisible by any modulator, the result will contain the string value of numerical index being tested against.
        /// </summary>
        /// <param name="upperBound">The number of values to iterate through and perform modulus operations against. Max value: 50000000</param>
        /// <param name="modulators">An array of tuples <c>(int, string)</c> containing the number to perform modulus operation against and a corresponding string value.</param>
        /// <returns>Returns an enumeration of strings corresponding to each number checked.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the <c>upperBound</c> passed in is outside of 1 and the max length of an array.</exception>

        public static IEnumerable<String> GetNumbers(int upperBound, (int rightOperand, string value)[] modulators)
        {
            if (upperBound < 1 || upperBound > 50000000)
                throw new ArgumentOutOfRangeException(nameof(upperBound));

            var results = new List<String>();
            for (var i = 0; i < upperBound; i++)
            {
                var val = i + 1;
                StringBuilder sb = new StringBuilder();
                for (var j = 0; j < modulators.Length; j++)
                {
                    if (val % modulators[j].rightOperand == 0)
                        sb.Append(modulators[j].value);
                }

                if (sb.Length > 0)
                    results.Add(sb.ToString());
                else
                    results.Add(val.ToString());
            }
            return results;
        }
    }
}
