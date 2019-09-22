using MobileShop.MobileShop;
using System;

namespace MobileShop
{
    class Program
    {
        static void Main(string[] args)
        {
            ImobilePhone objMobilePhone = new ClassMobilePhoneNokia();
            objMobilePhone.GetNormal();
            Console.ReadLine();
        }
    }
}
