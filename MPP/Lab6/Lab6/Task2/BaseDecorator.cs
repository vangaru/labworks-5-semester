namespace Task2
{
    public class BaseDecorator : Account
    {
        protected Account Wrapee;
        public override int BooksCountPerMonth { get; set; }
        
        public BaseDecorator(Account wrapee)
        {
            Wrapee = wrapee;
        }
    }
}