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
                Console.WriteLine("please enter a number between 1 and 6");
                string userInput = Console.ReadLine();
                userNumber = Convert.ToInt32(userInput);
                switch(userNumber)
                {
                    case 1:
                        Student.getStudents(students);
                        continue;
                    case 2:
                        Console.WriteLine("hello 1");
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
