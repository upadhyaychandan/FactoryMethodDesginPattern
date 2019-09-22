using System;
using System.Collections.Generic;
using System.Text;

namespace MobileShop.MobileShop
{
    class ClassSamsungGalxy : ISmartMobile
    {
        public string GetModelDetails()
        {
            return "This Is Samsung Glaxy Smart pHONE";
        }
    }
    class SmasungGuru : INormalMobile
    {
        string INormalMobile.GetModelDetails()
        {
            return "his Is SamSung Gurur  Noram Phone";
        }
    }
}
