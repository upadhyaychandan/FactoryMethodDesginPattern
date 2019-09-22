using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesginProblem
{
     class Duck
    {
        public virtual  void Quck()
        {

        }


        public virtual void Swimming()
        {

        }
       

    }
    class Mallard : Duck
    {
        public override void Quck()
        {

        }
        public override void Swimming()
        {

        }
    }
    class redhead : Duck
    {
        public override void Quck()
        {

        }
        public override void Swimming()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mallard obj = new Mallard();
            redhead obj1 = new redhead();


        }
    }
}
