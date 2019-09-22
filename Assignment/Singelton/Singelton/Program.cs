using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singelton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singelton obj = Singelton.GetInstance;
            obj.Printmsg("Hi");
            Singelton obj1 = Singelton.GetInstance;
            obj1.Printmsg("hello");
            //Console.WriteLine(Singelton.count);
            Console.ReadLine();
        }
    }
}
