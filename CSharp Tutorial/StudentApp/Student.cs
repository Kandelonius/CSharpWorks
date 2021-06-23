using System;
using System.Collections.Generic;

namespace StudentApp
{
    class Student
    {
        int id { get; }

        public string studentName { get; set; }

        public int studentAge { get; set; }

        public string studentEmail { get; set; }

        private static int idSeed = 1;

        public Student(string name, int age, string email)
        {
            this.studentName = name;
            this.studentAge = age;
            this.studentEmail = email;
            this.id = idSeed;
            idSeed++;
        }

        public static void getStudents(List<Student> list)
        {
            if (list.Count > 0)
            {
                foreach(Student item in list)
                {
                    Console.WriteLine($"Student's name is {item.studentName}, ID #{item.id}, " +
                        $"student's age is {item.studentAge} and their email is {item.studentEmail}");
                }
            }
            else
            {
                Console.WriteLine("No records");
            }
        }
    }
}
