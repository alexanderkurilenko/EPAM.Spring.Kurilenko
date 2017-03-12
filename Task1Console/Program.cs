using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1Logic;

namespace Task1Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 100, 6, 1000, -200, 15,0,99 };
            Console.WriteLine(MaximumElementOfArray.SearchMaximum(array));
            Console.ReadKey();
        }
    }
}
