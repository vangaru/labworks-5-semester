using System;

namespace Task3
{
    public class CashMachine
    {
        private IState _currentState = new WaitingState();
        private CreditCard _creditCard;
        
        public void EnterCreditCard(CreditCard creditCard)
        {
            _creditCard = creditCard;
            _currentState = new AuthenticationState();
        }

        private void GetCreditCardBack()
        {
            if (_creditCard == null)
            {
                Console.WriteLine("Nothing to get back");
            }
            else
            {
                _creditCard = null;
                _currentState = new WaitingState();
            }
        }

        public void EnterPassword()
        {
            _currentState = _currentState.EnterPassword(_creditCard.Password) 
                ? new ReadyForOperationsState() 
                : new BlockedState();
        }

        public void WithdrawMoney(decimal amountOfMoney)
        {
            _currentState.WithdrawMoney(amountOfMoney, _creditCard.AmountOfMoney);
        }

        public void ShutDown()
        {
            _currentState.Shutdown();
            if (_currentState is BlockedState) return;
            GetCreditCardBack(); 
        }
    }
}