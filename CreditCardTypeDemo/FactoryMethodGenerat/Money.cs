using System;
using System.Collections.Generic;
using System.Text;
using CreditCardTypeDemo.ProducatCard;

namespace CreditCardTypeDemo.FactoryMethodGenerat
{
    class MoneyBackManager : IFactoryCreate
    {
        private int _CreditcardLimit;
        private int _CreditCradCharge;
        public MoneyBackManager(int creditLimt, int CreditCharge)
        {
            _CreditcardLimit = creditLimt;
            _CreditCradCharge = CreditCharge;
        }
        public ICreditCardManger Generatefactory()
        {
            return new MoneyBackCard(_CreditcardLimit, _CreditCradCharge);
        }
    }
}
