using System;
using System.Collections.Generic;
using System.Text;

namespace MobileShop.MobileShop
{
    class ClassMobilePhoneSmasung : ImobilePhone
    {
        public INormalMobile GetNormal()
        {
            return new SmasungGuru();
        }

        public ISmartMobile GetSmart()
        {
            return new ClassSamsungGalxy();
        }
    }
}
