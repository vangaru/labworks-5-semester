using System;

namespace Task2
{
    public class AccountManager
    {
        private enum AccountVariant
        {
            Basic = 0,
            Standard = 3,
            Premium = 5
        }
        
        private Account _userAccount = new BasicAccount();
        private AccountVariant _boughtBooksCount;

        public void BuyBook(string name)
        {
            Console.WriteLine($"Book {name} is bought");
            _boughtBooksCount++;
            UpdateAccount();
            Console.WriteLine(_userAccount.BooksCountPerMonth);
        }

        private void UpdateAccount()
        {
            switch (_boughtBooksCount)
            {
                case AccountVariant.Basic:
                    break;
                case AccountVariant.Standard:
                    _userAccount = new StandardAccount(_userAccount);
                    break;
                case AccountVariant.Premium:
                    _userAccount = new PremiumAccount(_userAccount);
                    break;
            }
        }

    }
}