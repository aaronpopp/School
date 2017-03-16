using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId,
                int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
            : this(name, studentId, 0, 0) { }

        public Student(string name)
            : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        public void AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate fields: numberOfCredits, gpa
            
            NumberOfCredits += courseCredits;

        }

        public string GetGradeLevel()
        {
            // Determine the grade level of the student based on numberOfCredits
            if (NumberOfCredits < 30)
            {
                return "Freshman";
            }
            else if (NumberOfCredits > 29 || NumberOfCredits < 60)
            {
                return "Sophomore";
            }
            else if (NumberOfCredits > 59 || NumberOfCredits < 90)
            {
                return "Junior";
            }
            else
            {
                return "Senior";
            }

        }

    }

    public class Course
    {
        private string name;
        private int courseId;
        private List<Student> students;
    }

    public class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}
