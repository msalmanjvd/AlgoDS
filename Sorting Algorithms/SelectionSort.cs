using System;

namespace SortingAlgorithms
{
    public class SelectionSort : ISort
    {

        public int[] Sort(int[] input)
        {
            return RunSelectionSort(input);
        }


        static int [] RunSelectionSort(int[] intArray)
        {
            for (int outer = 0; outer < intArray.Length; outer++)
            {
                int min = Int32.MaxValue;
                int minLoc = 0;
                for (int inner = outer; inner < intArray.Length; inner++)
                {
                    if (intArray[inner] < min)
                    {
                        minLoc = inner;
                        min = intArray[inner];
                    }
                }

                //swap
                int temp = intArray[outer];
                intArray[outer] = min;
                intArray[minLoc] = temp;
            }
            return intArray;
        }

       
    }
}
