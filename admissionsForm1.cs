//This program simply creates variables and displays the values in the console
using System;

class MainClass {
  public static void Main (string[] args) {

    //Created Variables and added values
    string sFirstName = "Nate";
    string tFirstName = "Cliff";
    string sLastName = "K";
    string tLastName = "C";
    DateTime sBirthDate = new DateTime(1990, 8, 1);
    DateTime tBirthDate = new DateTime(1980, 5, 14);
    string sAddressLine1 = "111 Broadway Avenue";
    string tAddressLine1 = "123 West Avenue";
    string sAddressLine2 ="Apt 1";
    string tAddressLine2 ="";
    string sCity = "Atlanta";
    string tCity = "Doraville";
    string sState = "GA";
    string tState = "GA";
    int sZipcode = 30340;
    int tZipcode = 30340;
    string sCountry = "United States";
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
    Console.WriteLine("Name: {0} {1}", tFirstName, tLastName );
    Console.WriteLine("Birth Date: {0}", tBirthDate);
    Console.WriteLine("Address: \n{0}, {1}. \n{2}, {3} {4}, {5}", tAddressLine1, tAddressLine2, tCity, sState, sZipcode, sCountry);
    Console.WriteLine("\n");
    Console.WriteLine("UProgram Information");
    Console.WriteLine("Program Name: {0}", uProgramProgramName);
    Console.WriteLine("Department Head: {0}", uProgramDepartmentHead);
    Console.WriteLine("Degrees: {0}", degreeName);
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
