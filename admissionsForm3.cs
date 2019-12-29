//This program demonstrates getting and printing information from a user using 4 methods called in the main class 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentInformation
{
    class Program
    {
        static void Main()
        {
            //using the try catch method to throw any methods that haven't been implemented 
            try
            {
                //using the student class to access the methods because we cannot access through the new instance of Student
                Student.AddStudentInfo();
                Student.AddTeacherInfo();
                Student.PrintInfo(); 
                Student.ValidateBirthday();

            }
            catch (NotImplementedException notImp)
            {
                Console.WriteLine("The following method has not been implemented: " + notImp.TargetSite);
            }

        }
        
        //Class
        //using static keyword on all methods to create only one instance of them in memory
        public class Student
        {
            //Constructor
            public Student (){
                }

            //Method 1
            public static void AddStudentInfo() 
            {
                Console.WriteLine("First name: ");
                firstName = Console.ReadLine();

                Console.WriteLine("Last name: ");
                lastName = Console.ReadLine();

                Console.WriteLine("Birthday: ");
                birthday = Console.ReadLine();

            }

            //Method 2
            public static void AddTeacherInfo()
            {
                Console.WriteLine("Teacher name: ");
                teacherName = Console.ReadLine();

                Console.WriteLine("Course: ");
                course = Console.ReadLine();

                Console.WriteLine("Degree: ");
                degree = Console.ReadLine();

            }

            //Method 3
            public static void ValidateBirthday()
            {
                // Not developed yet.
                throw new NotImplementedException();
            }

            //Method 4
            public static void PrintInfo()
            {
                //Output to the console window               
                Console.WriteLine("{0} major {1} {2} was born {3} and has a {4} course with {5}", degree, firstName, lastName, birthday, course, teacherName);

            }
            
            //Creating class fields/variables
            public static string firstName;
            public static string lastName;
            public static string birthday;
            public static string teacherName;
            public static string course;
            public static string degree;
        }

        
    }
}
