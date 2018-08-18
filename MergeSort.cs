using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class MergeSort
    {
        private static int[] temp;
        public static void Sort(int[] data)
        {
            mergeSort(data);
        }

        private static void mergeSort(int[] data)
        {
            if (data.Length != 1)
            {
                int leftArrLength = (int)Math.Ceiling((decimal)data.Length / 2);
                int[] left = new int[leftArrLength];
                copy(left, data, 0, leftArrLength - 1);
                int[] right = new int[data.Length -leftArrLength];
                copy(right, data, leftArrLength, data.Length - 1);

                mergeSort(left);
                mergeSort(right);

                int[] result = new int[left.Length + right.Length];
                merge(result, left, right);
                data = (int[]) result.Clone();
            }
           
        }

        private static void merge(int[] result, int[] left, int[] right)
        {
            int k = 0, leftIndex = 0, rightIndex = 0;
            int minLength = right.Length; //right mustbe array with minimum length since when the data length is odd, it take the minimum length
            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                if(left[leftIndex] < right[rightIndex])
                {
                    result[k++] = left[leftIndex++];
                }else
                {
                    result[k++] = right[rightIndex++];
                }
            }
            while (leftIndex < left.Length) result[k++] = left[leftIndex++];
            while (rightIndex < right.Length) result[k++] = right[rightIndex++];
        }

        /**
         * Utils
         */
        private static void copy(int[] dest, int[] source, int idxStart, int idxStop)
        {
            int idxDest = 0;
            while (idxStart <= idxStop)
            {
                dest[idxDest++] = source[idxStart++];
            }
        }

    }

    
}
