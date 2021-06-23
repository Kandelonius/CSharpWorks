using System;
using System.Collections.Generic;

namespace StudentApp
{
    class StudentMain
    {
        static void Main(string[] args)
        {
            int userNumber = 1;
            var students = new List<Student>();
            Student james = new Student("james", 28, "a@b.c");
            students.Add(james);
            do
            {
                Console.WriteLine($"please enter a number between 1 and 6\n" +
                    "1- Show all student records \n2- Show a selected student records \n" +
                    "3- Add a new student \n4- Update student details \n" +
                    "5- Delete a student \n6- Quit");
                string userInput = Console.ReadLine();
                userNumber = Convert.ToInt32(userInput);
                switch(userNumber)
                {
                    case 1:
                        Student.getStudents(students);
                        continue;
                    case 2:
                        Console.WriteLine("Please enter a user id to retrieve their records.");
                        userInput = Console.ReadLine();
                        int tryId = Convert.ToInt32(userInput);
                        Student.getSingleStudent(students, tryId);
                        continue;
                    case 3:
                        Console.WriteLine("hello 1");
                        continue;
                    case 4:
                        Console.WriteLine("hello 1");
                        continue;
                    case 5:
                        Console.WriteLine("hello 1");
                        continue;
                    case 6:
                        Console.WriteLine("We're done here");
                        break;

                    default:
                        Console.WriteLine($"{userNumber} is not a valid input, must be between 1 and 6");
                        continue;
                }

            } while (userNumber != 6);
            
            //Console.WriteLine(james.studentName);
            //james.studentName = "Josh";
            //Console.WriteLine(james.ToString());
            Console.ReadKey();
        }
    }
}
