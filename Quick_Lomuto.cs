using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Quick_Lomuto
    {

        public static void doSort(int[] arr)
        {
            doQuick(arr, 0, arr.Length - 1);
        }

        private static void doQuick(int[] arr, int left, int right)
        {
            if (left >= right)
            {
                return;
            }
            
            int idx = Partitioning(arr, left, right);
            doQuick(arr, left, idx - 1);
            doQuick(arr, idx + 1, right);
        }

        private static int Partitioning(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left - 1;
            for (int j = left; j < right; j++)
            {
                if (arr[j] <= pivot)
                {
                    if (j == i + 1)
                    {
                        i++;
                    }
                    else
                    {
                        swap(arr, ++i, j);
                    }
                }
                    
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
