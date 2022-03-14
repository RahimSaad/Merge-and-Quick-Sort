using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Quick_Hoare
    {
        public static void doSort(int[] arr)
        {
            doQuick(arr, 0, arr.Length - 1);
        }
        private static void doQuick(int[] arr, int left, int right)
        {
            if(left >= right)
            {
                return;
            }
            int mid = (left + right) / 2;
            int pivot = arr[mid];
            int idx = Partitioning(arr, left, right, pivot);
            doQuick(arr, left, idx - 1);
            doQuick(arr, idx, right);
        }
        private static int Partitioning(int[] arr, int left, int right, int pivot)
        {
            while (left <= right)
            {
                while(arr[left] < pivot)
                    left++;
                while (arr[right] > pivot)
                    right--;
                if (left <= right) 
                {
                    swap(arr, left, right);
                    left++;
                    right--;
                }
            }
            return left;
        }
        private static void swap(int[] arr, int left, int right)
        {
            int tmp = arr[left];
            arr[left] = arr[right];
            arr[right] = tmp;
        }
    }
}
