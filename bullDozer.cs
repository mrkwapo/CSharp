//This program demonstrates using a public class method with a constructor to assign properties to instantiations
using System;

namespace Bulldozer {
    class Program {
        static void Main(string[] args) {
            //Instantiating the BullDozer Class
            //The constructor in the Bulldozer class allows us to set the size and color properties as arguments
            var dozer = new BullDozer("Yellow", "Mini"); // This is creating a new instance of the bulldozer

            //assigning properties to the dozer
            //dozer.color = "Yellow"; //Using dot notation to set the color of this object to yellow
            //dozer.size = "Mini"; //Using dot notation to set size

            //Instantiating another bulldozer
            var dozer2 = new BullDozer("Red", "Large");

            //assigning properties to the dozer
            //dozer2.color = "Blue"; 
            //dozer2.size = "Large"; 
            Console.WriteLine("The {0} Bulldozer is {1} and the {2} Bulldozer is {3}.", dozer.size, dozer.color, dozer2.size, dozer2.color);
        }
    }

    public class BullDozer {
        //To avoid writing the same code over and over we use constructors
        //Constructors are placed inside a class at the top, and have the same name as the class
        public BullDozer(string _color, string _size) {
            this.color = _color;
            this.size = _size;
        }
        //the constructor above assigns the variables size and color from below to Sting _colr and _size and accepts them as arguments.

        //means that any object that uses this class will have the following properties
        public string color { get; set; }
        public string size { get; set; }
}
}
