using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Merge
    {
        private static int[] Result;
        // this method must lock other thread from executing it while being executed by other thread (lock) so that tmp cannot be altered during execution
        public static void doSort(int[] arr)
        {
            Result = new int[arr.Length];         // reset the Data
            doMerge(arr, 0, arr.Length - 1);
            Result = null;                        // delete the auxiliary storage
        }
        private static void doMerge(int[] arr, int low, int high)
        {
            if (low == high)
                return;

            int mid = (low + high) / 2;
            doMerge(arr, low, mid);
            doMerge(arr, mid + 1, high);
            Combine(arr, low, mid, high);
        }
        private static void Combine(int[] arr, int low, int mid, int high) 
        {
            int i = low;  int j = mid + 1;  int k = low;
            while (i <= mid && j <= high)
            {
                if (arr[i] < arr[j])
                    Result[k] = arr[i++];
                else 
                    Result[k] = arr[j++];
                k++;
            }
            while (i <= mid)
            {
                Result[k++] = arr[i++];
            }
            while (j <= high)
            {
                Result[k++] = arr[j++];
            }
            // copy the sorted data to the original array
            for (int p = low; p <= high; p++) 
            {
                arr[p] = Result[p]; 
            }
        }
    }
}
