using System;

namespace Task3
{
    public class WaitingState : IState
    {
        public WaitingState()
        {
            AskForCreditCard();
        }
        
        public bool EnterPassword(string creditCardPassword)
        {
            AskForCreditCard();
            return true;
        }

        public void WithdrawMoney(decimal amountOfMoney, decimal amountOfMoneyOnTheCard)
        {
            AskForCreditCard();
        }

        public void Shutdown()
        {
            AskForCreditCard();
        }

        private static void AskForCreditCard()
        {
            Console.WriteLine("Please, enter your credit card");
        }
    }
}