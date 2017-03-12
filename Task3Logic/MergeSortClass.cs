using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Logic
{
    public static class MergeSortClass
    {
        /// <summary>
        /// Merge function
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="left"></param>
        /// <param name="mid"></param>
        /// <param name="right"></param>
        public static void Merge(int[] numbers, int left, int mid, int right)
        {
            if (numbers == null)
            {
                throw new NullReferenceException();
            }
            
            if (left < 0 || mid < 0 || right < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            int[] temp = new int[numbers.Length];
            int i, left_end, num_elements, tmp_pos;

            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[tmp_pos++] = numbers[left++];
                else
                    temp[tmp_pos++] = numbers[mid++];
            }

            while (left <= left_end)
                temp[tmp_pos++] = numbers[left++];

            while (mid <= right)
                temp[tmp_pos++] = numbers[mid++];

            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

        /// <summary>
        /// Recursice MergeSort Function
        /// </summary>
        /// <param name="array"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        public static void MergeSort(int[] array, int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSort(array, left, mid);
                MergeSort(array, (mid + 1), right);
                
                Merge(array, left, (mid + 1), right);
            }
        }
    }
}
