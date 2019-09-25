using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateCallBack
{
    public delegate bool checkEligbility(Emp e);
    public class Emp
    {
        public string Name;
        public int Sal;
        public void CalculatePromAtion(List<Emp> obj,checkEligbility objdelgate)
        {
            foreach (Emp e in obj)
            {
                if (objdelgate(e))
                {
                    Console.WriteLine("Eilgable");
                }
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            List<Emp> obj = new List<Emp>();
            obj.Add(new Emp { Name = "Amit", Sal = 100 });
            Emp obj1 = new Emp();
            checkEligbility delobj = new checkEligbility(IsPromateable);
            obj1.CalculatePromAtion(obj, delobj);
        }
       static bool IsPromateable(Emp e)
        {
         if(e.Sal>5)
            {
                Console.WriteLine("IsPromte");
            }
            return true;
        }
    }
}
