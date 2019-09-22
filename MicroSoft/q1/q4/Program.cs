using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q4
{
    class Program
    {
        private static string result;
        static DateTime time;
        static int Main(string[] args)
        {
            // SaySomething();
            int a = 10, b = 2,c=0;
            try
            {
                return c = a / b;
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
               // return a ;
            }
           
          
        }


        static async Task<string> SaySomething()
        {
            await Task.Delay(5);
            result = "hello wrod";
            return "Something";
        }
    }
    // public class teststatic
    //{
    //    public static int testval;
    //    public teststatic()
    //    {
    //        if(testval==0)
    //        {
    //            testval = 5;
    //        }
    //    }
    //    static teststatic()
    //    {
    //        if (testval == 0)
    //        {
    //            testval = 10; ;
    //        }
    //    }
    //    public void print()
    //    {
    //        if(testval==5)
    //        {
    //            testval = 6;
    //        }
    //        Console.Write(testval);
    //    }
    //}
}
