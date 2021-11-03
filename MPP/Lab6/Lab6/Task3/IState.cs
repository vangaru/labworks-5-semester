namespace Task3
{
    public interface IState
    {
        public bool EnterPassword(string creditCardPassword);
        public void WithdrawMoney(decimal amountOfMoney, decimal amountOfMoneyOnTheCard);
        public void Shutdown();
    }
}