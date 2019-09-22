using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayComapre
{
    class ComareArray
    {
        public static List<int> ArrayCompare(int [] arr1,int [] arr2)
        {
            int L1 = arr1.Length;
            int L2 = arr2.Length;
            if (L1 != L2)
            Console.WriteLine("Lenth are not Same");
            Array.Sort(arr1);Array.Sort(arr2);
            List<int> nonMatching = new List<int>();
            for(int i=0;i<L1;i++)
            {
                if(arr1[i]!=arr2[1])
                {
                    nonMatching.Add(arr1[i]);
                }
            }
            return nonMatching;
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //    int[] arr1 = { 1, 5, 8, 5, 7 };
            //    int[] arr2 = { 9,11, 6, 3, 2 };
            //    var x = ComareArray.ArrayCompare(arr1, arr2);
            demo1 obj = new demo1();

        }
    }
    class Demo
    {
        public static int a = 10;
        static Demo()
        {
            a = 20;
        }
        public Demo()

        {
            a = 30;
        }
        public Demo(int b)

        {
            a = 30;
        }
    }
    class demo1: Demo
    {
        public demo1() : base(10)
        {
            a = 40;
        }
    }
}
