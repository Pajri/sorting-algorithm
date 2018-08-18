using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class InsertionSort
    {
        public static void Sort(int[] data)
        {
            for (int i = 1; i < data.Length; i++)
            {
                int index = data[i];
                int j = i;
                while (j>0 && data[j-1]>index)
                {
                    data[j] = data[j - 1];
                    j--;
                }

                data[j] = index;
            }
        }
    }

    
}
