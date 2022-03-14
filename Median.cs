using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Median
    {
        public static int GetMedian(int[] arr)
        {
            return (Select(arr, 0, arr.Length - 1, arr.Length / 2));
        }

        private static int Select(int[] arr, int left, int right, int order)
        {
            if (left == right)
                return arr[left];
            int pivot = Partitioning(arr, left, right);
            if (pivot == order)
                return arr[pivot];
            else if (order < pivot)
                return Select(arr, left, pivot - 1, order);
            else
                return Select(arr, pivot + 1, right, order);
        }

        private static int Partitioning(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left - 1;
            for (int j = left; j < right; j++)
            {
                if (arr[j] <= pivot)
                    swap(arr, ++i, j);
            }
            swap(arr, i + 1, right);
            return (i + 1);

        }

        private static void swap(int[] arr, int left, int right)
        {
            int tmp = arr[left];
            arr[left] = arr[right];
            arr[right] = tmp;
        }
    }
}
