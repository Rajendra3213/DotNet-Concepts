using System;

namespace DotNetPractise
{
    public class IndexerExample
    {
        class Student
        {
            private int roll;
            public int Roll
            {
                get { return roll; }
                set { roll = value; }
            }

            private int[] marks = new int[3];
            public int this[int index]
            {
                get { return marks[index]; }
                set { marks[index] = value; }
            }

            public double GetPercent()
            {
                double total = 0.0;
                foreach (int m in marks)
                {
                    total += m;
                }

                // Divide the total marks by the total possible marks (300 in this case)
                return (total / 300) * 100;
            }
        }

        //public static void Main(string[] args)
        //{
        //    Student student = new Student();
        //    student.Roll = 1;
        //    student[0] = 30;
        //    student[1] = 70;
        //    student[2] = 80;
        //    double percent = student.GetPercent();
        //    Console.WriteLine("Total Marks obtained is {0} and percent is {1} % of Roll No. {2}",
        //        student.GetPercent(), percent, student.Roll);
        //    Console.ReadKey();
        //}
    }
}
