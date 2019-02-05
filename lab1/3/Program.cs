using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Double(int[] arr, int[] arr1)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                arr1[2 * i] = arr1[2 * i + 1] = arr[i];
            }
            foreach(int i in arr1)
            {
                Console.Write(i + " ");
            }
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int a = int.Parse(s);
            string ss = Console.ReadLine();
            int[] arr = new int[a];
            string[] sss = ss.Split(' ');
            int[] arr1 = new int[2*a];
            for(int i = 0; i < sss.Length; i++)
            {
                arr[i] = int.Parse(sss[i]);
            }
            Double(arr, arr1);
        }
    }
}
//3
//1 2 3
// 0 1- 1
//2 3 -2
//4 5-3