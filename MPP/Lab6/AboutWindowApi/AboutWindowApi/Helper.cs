namespace AboutWindowApi
{
    public class Helper
    {
        public static bool ReadyToKill(int hitPoints, bool instantKill)
        {
            return hitPoints <= 0 || instantKill;
        }

        public static bool NoRemainingBricks(int bricksCount)
        {
            return bricksCount <= 0;
        }
    }
}