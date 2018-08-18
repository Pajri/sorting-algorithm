using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[] { 2, 3, 4, 20, 19, 1, 1, 1, 2, 2 };

            Console.WriteLine("Data :");
            Console.WriteLine(string.Join<int>(" ", data));
            Console.WriteLine("");

            Console.WriteLine("Bucket Sort : ");
            BucketSort.Sort(data);
            Console.WriteLine(string.Join<int>(" ", data));
            Console.WriteLine("");

            Console.WriteLine("Bubble Sort : ");
            BubbleSort.Sort(data);
            Console.WriteLine(string.Join<int>(" ", data));
            Console.WriteLine("");

            Console.WriteLine("Selection Sort : ");
            SelectionSort.Sort(data);
            Console.WriteLine(string.Join<int>(" ", data));
            Console.WriteLine("");

            Console.WriteLine("Insertion Sort : ");
            InsertionSort.Sort(data);
            Console.WriteLine(string.Join<int>(" ", data));
            Console.WriteLine("");

            Console.WriteLine("Merge Sort : ");
            MergeSort.Sort(data);
            Console.WriteLine(string.Join<int>(" ", data));
            Console.WriteLine("");

            Console.ReadLine();
        }
    }
}
