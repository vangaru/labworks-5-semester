using System;

namespace Task3
{
    public class CreditCard
    {
        private CreditCard instance;

        private string _number;
        private decimal _amountOfMoney;
        private string _password;

        public string Number
        {
            get => _number;
            init
            {
                if (value.Length != 8)
                {
                    throw new ArgumentException("Number must contain 8 characters", nameof(value));
                }

                _number = value;
            }
        }
        
        public decimal AmountOfMoney
        {
            get => _amountOfMoney;
            set
            {
                if (value <= 0m)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        "AmountOfMoney cannot be equal or less than zero");
                }
                
                _amountOfMoney = value;
            }
        }

        public string Password
        {
            get => _password;
            init
            {
                if (value.Length != 4)
                {
                    throw new ArgumentException("Password must contain 4 characters", nameof(value));
                }

                _password = value;
            }
        }
    }
}