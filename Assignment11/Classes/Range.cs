using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11.Classes
{
    internal class Range<T> where T : notnull, IComparable<T>
    {
        public T Min { get; set; }
        public T Max { get; set; }

        public Range(T min, T max)
        {
            if (min.CompareTo(max) > 0)
            {
                Console.WriteLine("minimum value must be less than or equal to maximum value");
            }

            Min = min;
            Max = max;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        }

        public T Length()
        {
            try
            {
                dynamic min = Min;
                dynamic max = Max;
                return max - min;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error calculating length. Your operation is not between numbers : " + ex.Message);
            }
            return default(T);
        }
    }
}
