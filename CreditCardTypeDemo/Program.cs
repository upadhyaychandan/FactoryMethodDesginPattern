using CreditCardTypeDemo.FactoryMethodGenerat;
using CreditCardTypeDemo.ProducatCard;
using System;

namespace CreditCardTypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactoryCreate obj = null;
            obj = new MoneyBackManager(10, 1);
            ICreditCardManger oj1= obj.Generatefactory();
            oj1.display();
            Console.ReadLine();
        }
    }
}
