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
            int[] arr = { 9, 8, 7, 6, 5, 12, -9, 14, 58, 27, 0 };
            //int[] arr = { 1, 2, 3, 5, 6 , 4 };
            //int[] arr = { 1, 2, 3, 99, 1, 2, 3 };

            Console.WriteLine(Median.GetMedian(arr));
           // TestMerge(arr);
            //TestMerge2(arr);
            //TestQuick_Hoare(arr);
            //TestQuick_Lumuto(arr);
        }

        private static void TestMerge(int[] arr)
        {
            Merge.doSort(arr);
            foreach (int x in arr)
            {
                Console.Write("  {0}  ", x);
            }
        }

        private static void TestMerge2(int[] arr)
        {
            Merge2.doSort(arr);
            foreach (int x in arr)
            {
                Console.Write("  {0}  ", x);
            }
        }

        private static void TestQuick_Hoare(int[] arr)
        {
            Quick_Hoare.doSort(arr);
            foreach (int x in arr)
            {
                Console.Write("  {0}  ", x);
            }
        }

        private static void TestQuick_Lumuto(int[] arr)
        {
            Quick_Lomuto.doSort(arr);
            foreach (int x in arr)
            {
                Console.Write("  {0}  ", x);
            }
        }

    }
}
