using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class SelectionSort
    {
        public static void Sort(int[] data)
        {
            for(int i = 0; i < data.Length-1; i++)
            {
                int min = i;
                for(int j = i + 1; j < data.Length; j++)
                {
                    if (data[min] > data[j])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    int temp = data[min];
                    data[min] = data[i];
                    data[i] = temp;
                }
            }
        }
    }
}
