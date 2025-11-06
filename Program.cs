using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_pro
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[15];
            int i;
            for (i = 0; i < arr.Length; i++)
            {

                arr[i] = int.Parse(Console.ReadLine());

            }
            for (i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.ReadKey();
        }
    }
}
