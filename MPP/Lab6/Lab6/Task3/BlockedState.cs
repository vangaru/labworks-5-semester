using System;

namespace Task3
{
    public class BlockedState : IState
    {
        public BlockedState()
        {
            ShowBlockedStateMessage();
        }
        
        public bool EnterPassword(string creditCardPassword)
        {
            ShowBlockedStateMessage();
            return true;
        }

        public void WithdrawMoney(decimal amountOfMoney, decimal amountOfMoneyOnTheCard)
        {
            ShowBlockedStateMessage();
        }

        public void Shutdown()
        {
            ShowBlockedStateMessage();
        }

        private static void ShowBlockedStateMessage()
        {
            Console.WriteLine("Cash machine is blocked");
        }
    }
}