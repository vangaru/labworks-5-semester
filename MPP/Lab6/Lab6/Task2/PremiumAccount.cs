namespace Task2
{
    public class PremiumAccount : BaseDecorator
    {
        public sealed override int BooksCountPerMonth { get; set; }

        public PremiumAccount(Account wrapee) : base(wrapee)
        {
            BooksCountPerMonth += Wrapee.BooksCountPerMonth += 10;
        }
    }
}