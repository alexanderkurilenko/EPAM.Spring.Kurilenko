using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Logic
{
    public static class BalancedElementOfArray
    {
       /// <summary>
       /// Search index of an element with the same left and right summ 
       /// </summary>
       /// <param name="array"></param>
       /// <returns></returns>
        public static int SearchOfBalancedElement(int[] array)
        {
            if (array == null)
            {
                throw new NullReferenceException();
            }

            int left = 0;
            int summ=array.Sum();
            for (int i = 0; i < array.Length-1; ++i)
            {
                left += array[i];
                summ -= array[i];
                if (left+array[i+1]==summ)
                {
                    return i+1;
                }
            }
            return -1;
        }
    }
}
