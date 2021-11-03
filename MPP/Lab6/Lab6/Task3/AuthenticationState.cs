using System;

namespace Task3
{
    public class AuthenticationState : IState
    {
        public bool EnterPassword(string creditCardPassword)
        {
            return TryToAuthenticate(creditCardPassword);
        }

        private static bool TryToAuthenticate(string creditCardPassword)
        {
            Console.Write("Please, enter your password: ");
            var enteredPassword = Console.ReadLine();
            return enteredPassword == creditCardPassword;
        }

        public void WithdrawMoney(decimal amountOfMoney, decimal amountOfMoneyOnTheCard)
        {
            Console.WriteLine("You must authenticate to continue");
        }

        public void Shutdown()
        {
            Console.WriteLine("Shutting down..");
        }
    }
}