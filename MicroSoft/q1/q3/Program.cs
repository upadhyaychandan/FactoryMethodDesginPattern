using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q3
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass b1 = new dervied();
            b1.f1();
            b1.f2();
            b1.f3();
            Console.ReadLine();
        }
    }
    class BaseClass
    {
        public void f1()
        {

        }
        public virtual void f2()
        {

        }
        public virtual void f3()
        {

        }
    }
    class dervied:BaseClass
    {
        new public void f1()
        {

        }
        public override void f2()
        {

        }
        public new  void f3()
        {

        }
    }
}
