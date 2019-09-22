using System;
using System.Collections.Generic;
using System.Text;

namespace MobileShop.MobileShop
{
   public interface ImobilePhone
    {
        ISmartMobile GetSmart();
        INormalMobile GetNormal();
    }
}
