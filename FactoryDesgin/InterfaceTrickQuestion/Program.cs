using Polymorphism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface I1
    {
        void GetA();
    }
    interface I2
    {
        void GetA(int A);
        void GetA(int A, int B);
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

        public void GetA(int A)
        {
            Console.WriteLine("Hi I2");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();

            a.Test(); // output --> "A::Test()"
            b.Test(); // output --> "B::Test()"
            c.Test(); // output --> "C::Test()"

            a = new B();
            a.Test(); // output --> "A::Test()"

            b = new C();
            b.Test(); // output --> "B::Test()"

            Console.ReadKey();
        }
    }
}
