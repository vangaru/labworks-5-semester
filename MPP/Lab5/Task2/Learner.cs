using System.Linq;

namespace Task2
{
    public abstract class Learner
    {
        public double Gpa { get; private set; }

        public void CalculateGpa(params double[] marks)
        {
            Gpa = marks.Average();
        }
    }
}