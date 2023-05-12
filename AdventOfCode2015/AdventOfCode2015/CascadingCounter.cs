using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace AdventOfCode2015
{
    public static class CascadingCounter<T>
    {
        /// <summary>
        /// Takes array of two values where one value increases counter and one value decreases counter.
        /// Returns counter after all items in array are considered.
        /// </summary>
        /// <remarks>Useful for figuring out net force applied in a direction. Used for day 1, and modified for day 2.</remarks>
        public static int CascadeCount<T>(T incrementValue, T decrementValue, T[] sourceArray)
        {
            int counter = 0;
            foreach (T value in sourceArray)
            {
                if (value.Equals(incrementValue))
                {
                    counter++;
                }
                else if (value.Equals(decrementValue))
                {
                    counter--;
                }
            }
            return counter;
        }
    }
}
