//This program asks a student for admission information and returns academic enrollment information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab1 {
    class Program {
        static void Main(string[] args) {
            //Created Variables and added values
            Console.WriteLine("Enter your First Name:");
            string sFirstName = Console.ReadLine();
            string tFirstName = "Cliff";
            Console.WriteLine("Enter your Last Name:");
            string sLastName = Console.ReadLine();
            string tLastName = "C";
            Console.WriteLine("Birth Year:");
            int birthYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Birth Month:");
            int birthMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Birth Day of the Month:");
            int birthDay = Convert.ToInt32(Console.ReadLine());
            DateTime sBirthDate = new DateTime(birthYear, birthMonth, birthDay);
            DateTime tBirthDate = new DateTime(1980, 5, 14);
            Console.WriteLine("Enter your street address:");
            string sAddressLine1 = Console.ReadLine();
            string tAddressLine1 = "123 West Avenue";
            Console.WriteLine("Enter your apartment number:");
            string sAddressLine2 = Console.ReadLine();
            string tAddressLine2 = "";
            Console.WriteLine("Enter your city:");
            string sCity = Console.ReadLine();
            string tCity = "Doraville";
            Console.WriteLine("Enter your state:");
            string sState = Console.ReadLine();
            string tState = "GA";
            Console.WriteLine("Enter your zipcode:");
            string sZipcode = Console.ReadLine();
            int tZipcode = 30340;
            Console.WriteLine("Enter your country:");
            string sCountry = Console.ReadLine();
            string tCountry = "United States";
            string uProgramProgramName = "Full Stack Development";
            string uProgramDepartmentHead = "Claude M.";
            string uProgramDegrees = "Bachelor of Science Degree";
            string degreeName = "Computer Science";
            int degreeCreditsRequired = 1000;
            string courseName = "React JS";
            int courseCredits = 4;
            int courseDuration = 21;
            string courseTeacher = "Jason W.";

            //Output to the console window
            Console.WriteLine("\n");
            Console.WriteLine("Student Information");
            Console.WriteLine("Full Name: {0} {1}", sFirstName, sLastName);
            Console.WriteLine("Birth Date: {0}", sBirthDate);
            Console.WriteLine("Address: \n{0}, {1}. \n{2}, {3} {4}, {5}", sAddressLine1, sAddressLine2, sCity, sState, sZipcode, sCountry);
            Console.WriteLine("\n");
            Console.WriteLine("Teacher Information");
            Console.WriteLine("Name: {0} {1}", tFirstName, tLastName);
            Console.WriteLine("Birth Date: {0}", tBirthDate);
            Console.WriteLine("Address: \n{0}, {1}. \n{2}, {3} {4}, {5}", tAddressLine1, tAddressLine2, tCity, tState, tZipcode, tCountry);
            Console.WriteLine("\n");
            Console.WriteLine("UProgram Information");
            Console.WriteLine("Program Name: {0}", uProgramProgramName);
            Console.WriteLine("Department Head: {0}", uProgramDepartmentHead);
            Console.WriteLine("Degrees: {0}", uProgramDegrees);
            Console.WriteLine("\n");
            Console.WriteLine("Degree Information");
            Console.WriteLine("Degree Name: {0}", degreeName);
            Console.WriteLine("Credits Required: {0}", degreeCreditsRequired);
            Console.WriteLine("\n");
            Console.WriteLine("Course Information");
            Console.WriteLine("Course Name: {0}", courseName);
            Console.WriteLine("Credits: {0}", courseCredits);
            Console.WriteLine("Duration in Weeks: {0}", courseDuration);
            Console.WriteLine("Teacher: {0}", courseTeacher);

        }
    }
}









    
  }
}
