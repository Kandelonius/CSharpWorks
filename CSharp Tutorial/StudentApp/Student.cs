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
            if (list.Count < 1)
            {
                Console.WriteLine("No records");
                return;
            }
            foreach (Student item in list)
            {
                Console.WriteLine($"Student's name is {item.studentName}, ID #{item.id}, " +
                    $"student's age is {item.studentAge} and their email is {item.studentEmail}");
            }
        }

        public static void getSingleStudent(List<Student> list, int id)
        {
            if (list.Count < 1)
            {
                Console.WriteLine("No records");
                return;
            }
            foreach (Student item in list)
            {
                if (item.id == id)
                {
                    Console.WriteLine($"Student's name is {item.studentName}, ID #{item.id}, " +
                        $"student's age is {item.studentAge} and their email is {item.studentEmail}");
                }
            }
        }

        public static void deleteStudent(List<Student> list, int id)
        {
            if (list.Count < 1)
            {
                Console.WriteLine("No records");
                return;
            }
            foreach (Student item in list)
            {
                if (item.id == id)
                {
                    Console.WriteLine($"Deleting student {item.studentName}, ID #{item.id}");
                    list.Remove(item);
                    return;
                }
            }
        }

        public static void updateStudent(List<Student> list, int id, int selection)
        {
            string input = "";
            string newName = "";
            string oldName = "";
            int newAge = 0;
            int oldAge = 0;
            string newEmail = "";
            string oldEmail = "";
            if (list.Count < 1)
            {
                Console.WriteLine("No records");
                return;
            }
            foreach (Student item in list)
            {
                if (item.id == id)
                {
                    switch (selection)
                    {
                        case 1:
                            Console.WriteLine($"Please enter a name to replace {item.studentName}'s name");
                            oldName = item.studentName;
                            newName = Console.ReadLine();
                            item.studentName = newName;
                            Console.WriteLine($"Updated {oldName} to {newName}");
                            break;
                        case 2:
                            Console.WriteLine($"Please enter the student's age to update from {item.studentAge}");
                            oldAge = item.studentAge;
                            input = Console.ReadLine();
                            newAge = Convert.ToInt32(input);
                            item.studentAge = newAge;
                            Console.WriteLine($"Updated {oldAge} to {newAge}");
                            break;
                        case 3:
                            Console.WriteLine($"Please enter an email to replace {item.studentName}'s email" +
                                $"from {item.studentEmail}");
                            oldEmail = item.studentEmail;
                            newEmail = Console.ReadLine();
                            item.studentEmail = newEmail;
                            Console.WriteLine($"Updated {oldEmail} to {newEmail}");
                            break;
                        default:
                            Console.WriteLine($"{selection} is an invalid selection");
                            break;
                    }
                    return;
                }
            }
            Console.WriteLine($"user {id} doesn't exist");
        }
    }
}
