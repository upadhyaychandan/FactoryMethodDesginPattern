using System;
using System.Collections.Generic;
using System.Text;
using CreditCardTypeDemo.ProducatCard;

namespace CreditCardTypeDemo.FactoryMethodGenerat
{
    class TitanumCardManger : IFactoryCreate
    {
        private int _CreditcardLimit;
        private int _CreditCradCharge;
        public TitanumCardManger(int creditLimt,int CreditCharge)
        {
            _CreditcardLimit = creditLimt;
            _CreditCradCharge = CreditCharge;
        }
      public  ICreditCardManger Generatefactory()
        {
            return new TitanumCard(_CreditcardLimit, _CreditCradCharge);
        }
    }
}
