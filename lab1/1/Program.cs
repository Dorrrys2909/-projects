using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static bool Prime(int a) //new  boolean function 
        {
            bool cnt = true; //boolean variable
            if (a <= 1) // 
            {
                return false;
            }
            else
            {
                for(int i = 2; i < a; i++)
                {
                    if (a % i == 0)
                        return false;
                }
            }
            return cnt;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int a = int.Parse(s);
            string ss = Console.ReadLine();
            int[] arr = new int[a];
            string[] sss = ss.Split(' ');

            for(int i = 0; i < sss.Length; i++)
            {
                arr[i] = int.Parse(sss[i]);
            }

            List<int> b = new List<int>();

            foreach(int q in arr)
            {
                if (Prime(q))
                {
                    b.Add(q);
                }
            }

            Console.WriteLine(b.ToArray().Length);
             
            foreach(int q in b)
            {
                Console.Write(q + " ");
            }
            Console.WriteLine();
        }
    }
}
