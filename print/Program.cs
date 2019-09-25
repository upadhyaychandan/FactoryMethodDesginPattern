using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = 0;
            int number = 1792;
            res = DoOperation(number);
           
                if(res>=10)
                {
                while (res >= 10)
                {
                    number = res;
                    res = DoOperation(number);
                }
                }
                 
            
            
            Console.WriteLine(res);
            Console.ReadLine();
        }
        static int DoOperation(int n)
        {
            int Sum = 0;
            while (n > 0)
            {
                Sum = Sum + (n % 10);
                n = n / 10;
            }
            return Sum;
        }
    }
}
