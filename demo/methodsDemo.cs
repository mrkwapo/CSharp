using System;

namespace MethodsDemo
{
    class Program
    {       
       
        static void Main(string[] args)
        {
            try
            {
             var num = int.Parse("abc"); //throws an incorrect format exception

            }
            catch (Exception)
            {

                Console.WriteLine("Conversion Failed");
               
            }

            int number;
            var result = int.TryParse("abc", out number); //TryParse does not throw an exception but you have to use out modifier and declare an integer separately
            if(result)
                Console.WriteLine(result); 
            else
                Console.WriteLine( "Conversion Failed");
        }

        //Moved code into a separated method
        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(5, 6, 7)); //the params keyword allows us to use the method with any size array
            Console.WriteLine(calculator.Add(5, 6));
            Console.WriteLine(calculator.Add(5, 6, 7, 8));
            //or
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4 })); //but it is easier to use the params keyword to avoid this

        }

        //Moved code into a method
        static void UsePoints()
        {
            try // to avoid program from crashing and instead returning the error message indicated in the catch block 
            {
                var point = new Point(10, 20);

                //point.Move(new Point(40,60)); //using the Method 2 overload with the Point object as an arguement
                point.Move(null); // demonstrating null exception

                Console.WriteLine("Point is at {0}, {1}", point.X, point.Y);


                point.Move(100, 200); //using Method 1 overload 
                Console.WriteLine("Point is at {0}, {1}", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured");

            }
        }
    }
}

//Points.cs
/*using System;


namespace MethodsDemo
{
    public class Point
    {
        //declaring fields
        public int X;
        public int Y;

        //creating a constructors

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        //creating method 1
        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;

        }

        //Overloading Method 2 with a Point object 
        public void Move(Point newLocation)
        {
            if (newLocation == null)
                throw new ArgumentNullException("newLocation"); //defensive programming in case there is a null value
            Move(newLocation.X, newLocation.Y); //calling the first method in here
            //this.X = newLocation.X;
            //this.Y = newLocation.Y;
        }
    }
}*/

//Calculator.cs
/*namespace MethodsDemo
{
    public class Calculator
    {
        //Method
        public int Add(params int[] numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
}*/
