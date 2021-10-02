using System;

namespace L1._7_GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What was the Programming challenge I marks(%)?");
            float pChallengeI = float.Parse(Console.ReadLine());

            Console.WriteLine("What was the Programming challenge II marks(%)?");
            float pChallengeII = float.Parse(Console.ReadLine());

            Console.WriteLine("What was the Capstone Project marks(%)?");
            float cProject = float.Parse(Console.ReadLine());

            float overallMarks = (pChallengeI * 0.3f) + (pChallengeII * 0.3f) + (0.4f * cProject);

            Console.WriteLine("Programming challenge I marks: " + pChallengeI.ToString("F1") + "%");
            Console.WriteLine("Programming challenge II marks: " + pChallengeII.ToString("F1") + "%");
            Console.WriteLine("Capstone Project marks: " + cProject.ToString("F1") + "%");
            Console.WriteLine("Overall marks: " + overallMarks.ToString("F1") + "%");
        }
    }
}
