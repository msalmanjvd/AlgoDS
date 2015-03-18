using System;

namespace SortingAlgorithms 
{
    #region QuickSort

    public class QuickSort : ISort
    {
        public int ComparisonsNumber = 0;
        public int[] Sort(int[] input)
        {
            int FirstElementPivot = 0;
            int LastElementPivot = 1;
            int MedianElementPivot = 2;
            return RunQuickSort(input, 0, input.Length - 1, MedianElementPivot);

        }

        //Because I'm sending 0=> end-1 , the algorithm should work on all the element even end itself.
        private int[] RunQuickSort(int[] input, int start, int end, int PivotChoosingMethod)
        {
            int length = end - start + 1;
            if (length <= 1)
            {
                return input;
            }


            //Pivot Chossing Method
            int pivotIndex;
            if (PivotChoosingMethod == 0)
            {
                pivotIndex = ChoosePivotFirst(input, start, end);

            }
            else if (PivotChoosingMethod == 1)
            {
                pivotIndex = ChoosePivotLast(input, start, end);
                int temp = input[start];
                input[start] = input[pivotIndex];
                input[pivotIndex] = temp;
                pivotIndex = start;
            }

            else
            {
                pivotIndex = ChoosePivotMedian(input, start, end);
                int temp = input[start];
                input[start] = input[pivotIndex];
                input[pivotIndex] = temp;
                pivotIndex = start;
            }

            //Partitioning Part
            int pivot = input[pivotIndex];

            int i = pivotIndex + 1;

            for (int j = pivotIndex + 1; j <= end; j++)
            {
                if (input[j] < pivot)
                {
                    int temp = input[i];
                    input[i] = input[j];
                    input[j] = temp;
                    i++;
                }
            }


            input[pivotIndex] = input[i - 1];
            input[i - 1] = pivot;
            pivotIndex = i - 1;



            ComparisonsNumber += length - 1;
            RunQuickSort(input, start, pivotIndex - 1, PivotChoosingMethod);
            RunQuickSort(input, pivotIndex + 1, end, PivotChoosingMethod);

            return input;
        }

        private int ChoosePivotFirst(int[] input, int start, int end)
        {
            return start;
        }

        private int ChoosePivotLast(int[] input, int start, int end)
        {
            return end;
        }


        //The way of choosing median is done according to stanford course problemset
        private int ChoosePivotMedian(int[] input, int start, int end)
        {
            int middle;

            int length = end - start + 1;
            if (length % 2 == 0)
            {
                //1 2 3 4 => 2
                middle = start + (length / 2 - 1);
            }
            //1 2 3 4 5 => 3
            else middle = start + (length / 2);


            int[] arr = new int[3];
            arr[0] = input[start];
            arr[1] = input[end];
            arr[2] = input[middle];
            Array.Sort(arr);

            int pivot;

            if (arr[1] == input[middle])
                pivot = middle;

            else if (arr[1] == input[start])
                pivot = start;

            else
                pivot = end;

            Console.WriteLine("Pivot is" + input[pivot]);
            return pivot;

        }


    }

    #endregion 
}
