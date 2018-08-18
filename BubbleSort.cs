using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class BubbleSort
    {
        public static void Sort(int[] data)
        {
            for(int i=data.Length-1; i >= 0; i--)
            {
                for(int j = 1; j <= i; j++)
                {
                    if (data[j - 1] > data[j])
                    {
                        int temp = data[j - 1];
                        data[j - 1] = data[j];
                        data[j] = temp;
                    }
                }
            }
        }
    }

    
}
