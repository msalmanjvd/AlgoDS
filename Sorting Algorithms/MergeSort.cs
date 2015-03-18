
namespace SortingAlgorithms
{
    public class MergeSort : ISort
    {
        public int[] Sort(int[] array)
        {

            int[] newArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            return Sort(newArray, array, 0, array.Length - 1);
        }


        private int[] Sort(int[] newArray, int[] array, int startIndex, int endIndex)
        {

            int length = endIndex - startIndex + 1;
            if (length == 1)
            {
                return array;
            }
            int middle = startIndex + (endIndex - startIndex) / 2;

            Sort(newArray, array, startIndex, middle);
            Sort(newArray, array, middle + 1, endIndex);

            array = Merge(newArray, array, startIndex, endIndex);
            return array;
        }
        private static int[] Merge(int[] newArray, int[] array, int startIndex, int endIndex)
        {



            int middle = startIndex + (endIndex - startIndex) / 2;
            int i = startIndex;
            int j = middle + 1;
            for (int k = startIndex; k <= endIndex; k++)
            {


                if (i < middle + 1 && j < endIndex + 1)
                {
                    if (array[i] <= array[j])
                    {
                        newArray[k] = array[i];
                        i++;
                    }

                    else
                    {
                        newArray[k] = array[j];
                        j++;
                    }
                }

                else if (i < middle + 1)
                {
                    newArray[k] = array[i];
                    i++;
                }

                else
                {
                    newArray[k] = array[j];
                    j++;
                }
            }

            for (int k = 0; k < array.Length; k++)
            {
                array[k] = newArray[k];
            }
                    
            return array;
        }




        

    }



}
