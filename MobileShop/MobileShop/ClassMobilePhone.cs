using System;
using System.Collections.Generic;
using System.Text;

namespace MobileShop.MobileShop
{
    public class ClassMobilePhoneNokia : ImobilePhone
    {
       public INormalMobile GetNormal()
        {
            return new ClassNokia660();
        }

      public ISmartMobile GetSmart()
        {
            return new ClassNokiaN70();
        }
    }
}
