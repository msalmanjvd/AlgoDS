
namespace SortingAlgorithms
{
    class BubbleSort : ISort
    {
        public int[] Sort(int[] input)
        {
            return OptimizedBubbleSort(input);
        }


        //return if you are doing unnecessay loops
        int[] OptimizedBubbleSort(int[] intArray)
        {

            for (int outer = intArray.Length - 1; outer >= 1; outer--)
            {
                int swaps = 0;
                for (int inner = 0; inner < outer; inner++)
                {
                    int temp;
                    if (intArray[inner] > intArray[inner + 1])
                    {
                        temp = intArray[inner];
                        intArray[inner] = intArray[inner + 1];
                        intArray[inner + 1] = temp;
                    }


                }
                if (swaps == 0)
                {
                    return intArray;
                }
            }

            return intArray;
        }
    }
}
