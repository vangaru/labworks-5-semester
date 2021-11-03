namespace Task2
{
    public class StandardAccount : BaseDecorator
    {
        public sealed override int BooksCountPerMonth { get; set; }

        public StandardAccount(Account wrapee) : base(wrapee)
        {
            BooksCountPerMonth += Wrapee.BooksCountPerMonth + 5;
        }
    }
}