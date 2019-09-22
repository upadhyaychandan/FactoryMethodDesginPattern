using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardTypeDemo.ProducatCard
{
    public interface ICreditCardManger
    {
        string CreditCradType { get; }
        int CredicardLimit { get; set; }
        int CreditCardAnuualCharges { get; set; }
        void display();
    }

}
