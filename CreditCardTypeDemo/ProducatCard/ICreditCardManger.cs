using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardTypeDemo.ProducatCard
{
    public interface ICreditCardManger
    {
        string CreditCradType { get; set; }
        int CredicardLimit { get; set;}
        int CreditCardAnuualCharges { get; set;}

    }

    public class MoneyBackCard : ICreditCardManger
    {
        private int _CreditLimt;
        public MoneyBackCard()
        {

        }
        public string CreditCradType { get; } = "MoneyBack";
        public   int CredicardLimit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
     public   int CreditCardAnuualCharges { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public class Titanum : ICreditCardManger
    {
        public string CreditCradType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int CredicardLimit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int CreditCardAnuualCharges { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
