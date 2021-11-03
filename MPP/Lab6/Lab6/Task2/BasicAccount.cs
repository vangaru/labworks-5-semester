namespace Task2
{
    public class BasicAccount : Account
    {
        public sealed override int BooksCountPerMonth { get; set; }
        
        public BasicAccount()
        {
            BooksCountPerMonth = 5;
        }
    }
}