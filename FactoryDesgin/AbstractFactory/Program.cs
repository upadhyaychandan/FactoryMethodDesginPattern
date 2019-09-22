using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
  public  interface I1
    {
        void GetA();
    }
    interface I2
    {
         void GetA(int A);
        void GetA(int A,int B);
    }
      class D : I1, I2
    {
        public void GetA(int A, int B)
        {
            throw new NotImplementedException();
        }

        void I1.GetA()
        {
            Console.WriteLine("Hi I1");
        }

         public  void GetA(int A)
        {
            Console.WriteLine("Hi I2");
        }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            D obj = new D();
            obj.GetA(10);
        }
    }
}
