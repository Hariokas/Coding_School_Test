using System;

namespace _2_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int mathGoal = 65;
            int phyGoal = 55;
            int chemGoal = 50;
            int totalSubjectsGoal = 180;
            int totalMathAndPhyGoal = 140;

            Console.Write("Input the marks obtained in Physic: ");
            int phyMark = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the marks obtained in Chemistry: ");
            int chemMark = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the marks obtained in Mathematics: ");
            int mathMark = Convert.ToInt32(Console.ReadLine());

            int totalSubjectsMark = phyMark + chemMark + mathMark;
            int totalMathAndPhyMark = mathMark + phyMark;

            if (phyMark >= phyGoal && chemMark >= chemGoal && mathMark >= mathGoal && totalSubjectsMark >= totalSubjectsGoal || totalMathAndPhyMark >= totalMathAndPhyGoal)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }

        }
    }
}
