using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Logic
{

    public static class MaximumElementOfArray
    {
        /// <summary>
        /// Function for searching maximum value in array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="startInd"></param>
        /// <returns></returns>
        public static int SearchMaximum(int [] arr,int startInd=0)
        {
            if (arr == null)
            {
                throw new NullReferenceException();
            }

            int current = arr[startInd];

            if (startInd + 1 == arr.Length)
            {
                return current;
            }

            int next = SearchMaximum(arr, startInd + 1);

            if (current >= next)
            {
                return current;
            }

            return next;
        }
    }
}
