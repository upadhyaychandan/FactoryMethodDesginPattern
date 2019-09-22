using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesginPattern
{

    public abstract class DuckClass
    {
        abstract public void quck();
        abstract public void Swim();
        abstract public void dispaly();

        //virtual public void adf()
        //{

        //}

    }
    public class MallarDuck : DuckClass
    {
        public override void quck()
        {
            Console.WriteLine($"Hi 1 Quck");
        }

        public  override void dispaly()
        {
            Console.WriteLine($"Hi 2 Quck");
        }

        public override void Swim()
        {
            Console.WriteLine($"Hi 1 Swim");
        }
        //override public void adf()
        //{

        //}

    }
    class Program
    {
        static void Main(string[] args)
        {
            DuckClass obj = new MallarDuck();
            obj.quck(10);
        }
    }
}
