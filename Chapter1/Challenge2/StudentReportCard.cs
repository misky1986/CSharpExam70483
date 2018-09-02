using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter1.Challenge2
{
    class StudentReportCard
    {
        public void StudentReportCard1()
        {
            Console.WriteLine("Press any following key\n");

            Console.Write("Enter Total Students: ");
            int numbeOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>(numbeOfStudents);
            Student student = null;
            int studentCounter = 0;
            while(studentCounter < numbeOfStudents)
            {
                studentCounter += 1;
                Console.WriteLine("*****************************************\n");

                Console.Write("Enter Studen Name: ");
                string studentName = Console.ReadLine();
                
                Console.Write("Enter English Marks: ");
                int englishMarks = int.Parse(Console.ReadLine());

                Console.Write("Enter Math Marks: ");
                int mathhMarks = int.Parse(Console.ReadLine());

                Console.Write("Enter Computer Marks: ");
                int computerMarks = int.Parse(Console.ReadLine());

                student = new Student(studentCounter, studentName, englishMarks, mathhMarks, computerMarks);
                students.Add(student);                
            }

            WriteStudenReportCard(students);

            Console.ReadLine();
        }

        private void WriteStudenReportCard(List<Student> students)
        {
            Console.WriteLine("");
            Console.WriteLine("***************Report Card***************\n");            

            students.ForEach(student => {
                Console.WriteLine("*****************************************");
                Console.WriteLine(student.ToString());
            });
        }
    }
}

