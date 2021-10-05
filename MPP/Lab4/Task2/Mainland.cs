namespace Task2
{
    public class Mainland
    {
        public string Name { get; init; }
        public int Population { get; set; }
        public const int Area = 10000000;

        public void Wait_10Years()
        {
            Population += (int)(Population * 0.2);
        }

        public void Wait_20Years()
        {
            Population *= 2;
        }
    }
}