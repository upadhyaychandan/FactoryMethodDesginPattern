using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    class Program
    {
        static void Main(string[] args)
        {
            c OBJ = new c();
            A obj1 = new A();
            obj1 = OBJ;
            obj1.Show();
            OBJ.Show();
            Console.ReadLine();
        }
    }
    class A
    {
       // int i;
        public virtual void Show()
        {
          //  i = j;
            Console.WriteLine("A.show");
        }
    }
   class B : A
    {
        public override void Show()
        {
            //  i = j;
            Console.WriteLine("B.show");
        }
    }
    class c : B
    {
        public override void Show()
        {
            //  i = j;
            Console.WriteLine("C.show");
        }
    }
}
