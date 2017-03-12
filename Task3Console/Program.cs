using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3Logic;

namespace Task3Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { -1, 5, 7, 1, 100, 80 ,-20};
            MergeSortClass.MergeSort(array, 0, array.Length-1);
            for (int i = 0; i < array.Length; ++i)
            {
                Console.Write(array[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
