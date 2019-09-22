using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardTypeDemo.ProducatCard
{
    public class MoneyBackCard : ICreditCardManger
    {
        private int _CreditLimt;
        public int _CreditAnnualCharge;
        public MoneyBackCard(int creditLimt, int creditAnnualcharge)
        {
            _CreditLimt = CredicardLimit;
            _CreditAnnualCharge = creditAnnualcharge;
        }
        public string CreditCradType { get; } = "MoneyBack";
        public int CredicardLimit
        {
            get { return _CreditLimt; }
            set { _CreditLimt = value; }
        }
        public int CreditCardAnuualCharges
        {

            get { return _CreditAnnualCharge; }
            set { _CreditAnnualCharge = value; }
        }

        public void display()
        {
            Console.WriteLine("Hi MoneyBack");
        }
    }

    public class TitanumCard : ICreditCardManger
    {
        private int _CreditLimt;
        public int _CreditAnnualCharge;
        public TitanumCard(int creditLimt, int creditAnnualcharge)
        {
            _CreditLimt = CredicardLimit;
            _CreditAnnualCharge = creditAnnualcharge;
        }
        public string CreditCradType { get; } = "TitanumCard";
        public int CredicardLimit { get => CredicardLimit; set => CredicardLimit = value; }
        public int CreditCardAnuualCharges { get => _CreditAnnualCharge; set => _CreditAnnualCharge = value; }

        public void display()
        {
            Console.WriteLine("Hi Titanum");
        }
    }
}

