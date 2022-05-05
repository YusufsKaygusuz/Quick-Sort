using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick_Sort
{
    class Program
    {
        // Pivotun değerine göre küçük olanlar sol tarafta büyük olanlar sağ tarafta olacaktır.
        static public int Partition(int[] arr, int left, int right)
        {
            int pivot;
            pivot = arr[left];
            while(true)
            {
                while(arr[left]<pivot)
                {
                    left++;
                }
                while(arr[right]>pivot)
                {
                    right--;
                }
                if(left<right)
                {
                    int temp = arr[right];
                    arr[right] = arr[left];
                    arr[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }


        static public void quickSort(int[] arr, int left, int right)
        {
            int pivot;
            if(left<right)
            {
                pivot = Partition(arr, left, right);
                if (pivot > 1)
                    quickSort(arr, left, pivot - 1);
                if (pivot + 1 < right)
                    quickSort(arr, pivot + 1, right);    
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 67, 21, 96, 56, 84, 3, 100, 64, 14, 87, 65, 9, 7 };
            Console.WriteLine("Quick Sort");
            Console.WriteLine("-------------------------");
            Console.WriteLine("\nInitial Array is: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+ " ");
            }
            quickSort(arr, 0, arr.Length-1); // length-1 olmasının sebebi biz en sonuncu elemanın indis değerini yollamamızdan kaynakıdır.
            Console.WriteLine("\nSorted Array is: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.ReadLine();
        }
    }
}
