using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class BucketSort
    {
        public static void Sort(int[] data)
        {
            //find max value of data
            int max = Int32.MinValue;
            for (int i = 0; i < data.Length; i++)
                if (max < data[i])
                    max = data[i];

            
            int[] sorted = new int[max+1];
            for (int i = 0; i < sorted.Length; i++) sorted[i] = 0;
            for (int i = 0; i < data.Length; i++) sorted[data[i]] += 1;

            int a = 0;
            for(int i = 0; i < sorted.Length; i++)
            {
                if(sorted[i] != 0)
                {
                    for (int j = 0; j < sorted[i]; j++)
                    {
                        data[a++] = i;
                    }
                }
                
            }
        }
    }
}
