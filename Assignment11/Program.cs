using Assignment11.Classes;

namespace Assignment11
{
    internal class Program
    {
        //We can optimize a bubble sort by skipping the sorting if no swaps were made during the array passes.
        //also if there is no swapping in a pass, then the array was sorted and we can skip the remaining passes.

        public static void BubbleSortOptimized<T>(T[] array) where T : IComparable<T>
        {
            
            for (int i = 0; i < array.Length; i++)
            {
                bool isSwapped = false;
                for (int j = 0; j < array.Length-i-1; j++)
                {
                    if (array[j].CompareTo(array[j+1]) > 0)
                    {
                        isSwapped = true;
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
                if (!isSwapped) 
                {
                    break;
                }
            }
        }

        static void Main(string[] args)
        {
            #region Question 1
            int[] arr = { 9, 8, 7, 12, 25, 77, 2 };
            BubbleSortOptimized(arr);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            #endregion

            #region Question 2
            Range<int> intRange = new Range<int>(1, 15);
            Console.WriteLine("Is 10 in range: " + intRange.IsInRange(10));
            Console.WriteLine("Range length: " + intRange.Length());

            Range<string> stringRange = new Range<string>("1", "19");
            Console.WriteLine("Is 10 in range: " + stringRange.IsInRange("10"));
            Console.WriteLine("Range length: " + stringRange.Length());
            #endregion

        }
    }
}
