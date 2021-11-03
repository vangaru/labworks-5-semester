using System;

namespace Task3
{
    internal static class Program
    {
        private static void Main()
        {
            var creditCard = new CreditCard
            {
                Number = "11111111",
                Password = "1111",
                AmountOfMoney = 10000000m
            };
            var cashMachine = new CashMachine();
            cashMachine.EnterCreditCard(creditCard);
            cashMachine.EnterPassword();
            cashMachine.WithdrawMoney(100m);
            cashMachine.ShutDown();
        }
    }
}