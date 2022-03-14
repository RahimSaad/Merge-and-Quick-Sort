using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Merge2
    {
        // this method must lock other thread from executing it while being executed by other thread (lock) so that tmp cannot be altered during execution
        public static void doSort(int[] arr)
        {
            doMerge(arr, 0, arr.Length - 1);
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
            int k = low, i = low, j = mid+1;

            int[] L = new int[mid - low + 1];
            int[] R = new int[high - mid];

            for (int x = 0; x < L.Length; x++) 
                L[x] = arr[i++];

            for (int x = 0; x < R.Length; x++) 
                R[x] = arr[j++];

            i = j = 0;

            while (i < L.Length && j < R.Length) 
            {
                if (L[i] < R[j])
                    arr[k++] = L[i++];
                else
                    arr[k++] = R[j++];
            }
            while (i < L.Length) 
            {
                arr[k++] = L[i++];
            }
            while (j < R.Length)
            {
                arr[k++] = R[j++];
            }
        }
    }
}
