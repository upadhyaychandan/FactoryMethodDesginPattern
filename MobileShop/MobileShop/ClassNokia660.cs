using System;
using System.Collections.Generic;
using System.Text;

namespace MobileShop.MobileShop
{
    class ClassNokia660 : INormalMobile
    {
        public string GetModelDetails()
        {
            return "this Is Nokia 6600 Noram Phone";
        }
    }
    class ClassNokiaN70 : ISmartMobile
    {
        public string GetModelDetails()
        {
            return "this Is Nokia N70 Smart Phone";
        }
    }
}
