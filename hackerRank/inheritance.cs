/*You are given two classes, Person and Student, where Person is the base class and Student is the derived class. 
Completed code for Person and a declaration for Student are provided for you in the editor. Observe that Student inherits all the 
properties of Person.

Complete the Student class by writing the following:

A Student class constructor, which has  parameters:
A string, firstName.
A string, lastName.
An integer, id.
An integer array (or vector) of test scores, scores.
A char calculate() method that calculates a Student object's average and returns the grade character representative of their calculated
average:

Grading Scale
0: 90 <= a <=100
E: 80 <= a <90
A: 70 <= a <80
P: 55 <= a 70
D: 40 <= a 55
T: a < 40

Input Format

The locked stub code in your editor calls your Student class constructor and passes it the necessary arguments. 
It also calls the calculate method (which takes no arguments).

You are not responsible for reading the following input from stdin:
The first line contains firstName, lastName, and id, respectively. The second line contains the number of test scores. The third line of space-separated 
integers describes scores.

Constraints
1<=|firstName|,|lastName|<=10
|id| ==7
0 <= score, average <= 100

Output Format

This is handled by the locked stub code in your editor. Your output will be correct if your Student class constructor and calculate() method are properly implemented.

Sample Input

Heraldo Memelli 8135627
2
100 80
Sample Output

 Name: Memelli, Heraldo
 ID: 8135627
 Grade: O
*/

using System;
using System.Linq;

class Person 
{
    protected string firstName;
    protected string lastName;
    protected int id;

    public Person() 
    { 
    }
    public Person(string firstName, string lastName, int identification) 
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = identification;
    }
    public void printPerson() 
    {
        Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
    }
}

class Student : Person
{
    private int[] testScores;
    
    public Student(string firstName, string lastName, int id, int[]scores): base(firstName, lastName, id)
    {
        this.testScores = scores;
    }
    
    public char Calculate()
    {

        //create a way to add all numbers in testScores array 
        int total = testScores.Sum();


        //and divide by count of testScores
        var avg = total / testScores.Length;

        //create conditionals to handle integer to character conversion based on grading scale. 
        if (avg >= 90) 
        {
            return 'O';
        }
        if (avg >= 80) 
        {
            return 'E';
        }
        if (avg >= 70) 
        {
            return 'A';
        }
        if (avg >= 55) 
        {
            return 'P';
        }
        if (avg >= 40) 
        {
            return 'D';
        }
        return 'T';
        
    }
}

class Solution 
{
    static void Main() 
    {
        string[] inputs = Console.ReadLine().Split();
        string firstName = inputs[0];
        string lastName = inputs[1];
        int id = Convert.ToInt32(inputs[2]);
        int numScores = Convert.ToInt32(Console.ReadLine());
        inputs = Console.ReadLine().Split();
        int[] scores = new int[numScores];
        for (int i = 0; i < numScores; i++) 
        {
            scores[i] = Convert.ToInt32(inputs[i]);
        }

        Student s = new Student(firstName, lastName, id, scores);
        s.printPerson();
        Console.WriteLine("Grade: " + s.Calculate() + "\n");
    }
}
