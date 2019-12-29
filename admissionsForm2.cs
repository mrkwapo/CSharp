//This program demonstrates getting and printing information from a user using 4 methods called in the main class 
using System;

namespace studentInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //using the try catch method to throw the Not Implemented Exception 
            try
            {
                var student1 = new Student();
                student1.AddStudentInfo();
                student1.AddTeacherInfo();
                Student.PrintInfo();
                student1.ValidateBirthday();
            }
            catch (NotImplementedException notImp)
            {
                Console.WriteLine("The following method has not been implemented: " + notImp.TargetSite);
            }

        }                  
        

        //Class or Blueprint
        public class Student
        {
            //Constructor
            public Student (){
                }

            //Method
            public void AddStudentInfo()
            {
                Console.WriteLine("First name: ");
                firstName = Console.ReadLine();

                Console.WriteLine("Last name: ");
                lastName = Console.ReadLine();

                Console.WriteLine("Birthday: ");
                birthday = Console.ReadLine();

            }

            //Method
            public void AddTeacherInfo()
            {
                Console.WriteLine("Teacher name: ");
                teacherName = Console.ReadLine();

                Console.WriteLine("Course: ");
                course = Console.ReadLine();

                Console.WriteLine("Degree: ");
                degree = Console.ReadLine();

            }

            //Method
            public void ValidateBirthday()
            {
                // Not developed yet.
                throw new NotImplementedException();
            }

            //Method
            public static void PrintInfo()
            {
                //Output to the console window               
                Console.WriteLine("{0} major {1} {2} was born {3} and has a {4} course with {5}", degree, firstName, lastName, birthday, course, teacherName);

            }
            public static string firstName;
            public static string lastName;
            public static string birthday;
            public static string teacherName;
            public static string course;
            public static string degree;
        }

        
    }
}
