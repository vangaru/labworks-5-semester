using System;

namespace Task3
{
    public class ReadyForOperationsState : IState
    {
        public ReadyForOperationsState()
        {
            Console.WriteLine("Ready for operations");
        }
        
        public bool EnterPassword(string creditCardPassword)
        {
            Console.WriteLine("You are authenticated");
            return true;
        }

        public void WithdrawMoney(decimal amountOfMoney, decimal amountOfMoneyOnTheCard)
        {
            Console.WriteLine(amountOfMoney > amountOfMoneyOnTheCard ? "Not enough money" : "Success");
        }

        public void Shutdown()
        {
            Console.WriteLine("Shutting down..");
        }
    }
}