using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singelton
{
    sealed class Singelton
    {
       public static int count = 0;
        private Singelton()
        {
            count++;
        }
        private static readonly Singelton instance = new Singelton();
        public static Singelton GetInstance { get { return instance; }}
       public void Printmsg(string msg)
        {
            Console.WriteLine(msg);
        }

        
    }
}
