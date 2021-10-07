using System;

namespace Task2
{
    internal static class Program
    {
        private static void Main()
        {
            var pupil = new Pupil { SchoolName = "Gymnasium #41", Grade = 9 };
            var student = new Student { UniversityName = "BSUIR", Faculty = "Software development" };
            var learners = new Learner[] { pupil, student };
            foreach (var learner in learners)
            {
                Console.WriteLine(learner.ToString());
            }
        }
    }
}