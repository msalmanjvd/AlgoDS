
namespace SortingAlgorithms
{
    class InsertionSort : ISort
    {
        public int[] Sort(int[] input)
        {
            return MyInsertionSort(input);
        }

         int[] RunInsertionSort(int[] intArray)
        {

            for (int outer = 1; outer < intArray.Length; outer++)
            {
                int temp = intArray[outer];
                int inner = outer;
                while (inner > 0 && temp <= intArray[inner - 1])
                {
                    intArray[inner] = intArray[inner - 1];
                    inner--;
                }
                intArray[inner - 1] = temp;

            }

            return intArray;
        }

        static int[] MyInsertionSort(int[] intArray)
        {
            for (int i = 1; i < intArray.Length; i++)
            {
                int target = intArray[i];
                int targetLoc = i;
                int cnt = i;

                while (cnt > 0 && intArray[cnt - 1] > target)
                {
                    intArray[targetLoc] = intArray[cnt - 1];
                    intArray[cnt - 1] = target;
                    cnt--;
                    targetLoc--;
                }
            }

            return intArray;
        }
    }
}
