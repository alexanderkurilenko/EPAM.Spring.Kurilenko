using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2Logic;

namespace Task2Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] {-1,-1,0,0,3,3,10,-2,4,2};
            Console.WriteLine(BalancedElementOfArray.SearchOfBalancedElement(array));
            Console.ReadKey();
        }
    }
}
