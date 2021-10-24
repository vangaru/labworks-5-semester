using System;
using System.Collections;
using System.Collections.Generic;

namespace Task2
{
    internal static class Program
    {
        private static void Main()
        {
            var pupil1 = new Pupil { SchoolName = "Gymnasium #41", Grade = 9 };
            var pupil2 = new Pupil { SchoolName = "Gymnasium #41", Grade = 9 };
            var student1 = new Student { UniversityName = "BSUIR", Faculty = "Software development" };
            var student2 = new Student { UniversityName = "BSUIR", Faculty = "Software development" };
            var student3 = new Student { UniversityName = "BSUIR", Faculty = "Software development" };
            var learners = new Learner[] { pupil1, student1, student2, pupil2, student3 };
            PrintPupil(learners);
            PrintStudents(learners);
        }

        private static void PrintPupil(IEnumerable<Learner> l)
        {
            foreach (var learner in l)
            {
                if (learner is Pupil pupil)
                {
                    Console.WriteLine(pupil.SchoolName);
                }
            }
        }
        
        private static void PrintStudents(IEnumerable<Learner> l)
        {
            foreach (var learner in l)
            {
                if (learner is Student student)
                {
                    Console.WriteLine(student.UniversityName);
                }
            }
        }
    }
}