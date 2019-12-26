//Lego Lecture Challenge: This program was created with the following instructions:
//1. Make a Car class with properties: color and manufacturer
//2. Instantiate an object: 
	//Make car1 object and instatiate with:
		//a. color red
		//b. manufacturer Toyota
//3. Inheritance:
	//Make a SaloonCar class that inherits form Car class
	//add new property called: numberOfSeats

//4. Polymorphism:
	//Write 3 different constructors to do the following:
		//Constructor 1 - Allows assignment of numberOfSeats only
		//Constructor 2 - Allows assignment of numberOfSeats and manufacturer only
		//Constructor 3 - Allows assignment of numberOfSeats, manufacturer and color

	//Create 3 Objects: And when instatiated should only take one line
		//Create saloonCar1 with 2 seats.
		//Create saloonCar2 with 3 seats and manufacturer Nissan.
		//Create saloonCar3 with 4 seats, manufacturer Ford and color purple.
    
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carfactory
{
    class MainClass
    {
        static void Main(string[] args)
        {
            var car1 = new SaloonCar(); // Color and Manufacturer
            car1.color = "Red";
            car1.manufacturer = "Toyota";
            
            var saloonCar1 = new GeneralObject1("2"); // 2 seats

            var saloonCar2 = new Car("3", "Nissan"); // 3 seats and manufactured by Nissan

            var saloonCar3 = new SaloonCar("4", "Ford", "Purple"); // 4 seats, manufactured by Ford and color Purple
        }
        public class GeneralObject1
        {
            public GeneralObject1()
            {                
            }

            public GeneralObject1(string _numberOfSeats)
            {
                numberOfSeats = _numberOfSeats;
            }
            public string numberOfSeats { get; set; }
        }
        public class Car : GeneralObject1
        {
            public Car()
            {                         
            }

            public Car(string _numberOfSeats, string _manufacturer)
            {
                numberOfSeats = _numberOfSeats;
                manufacturer = _manufacturer;
            }
            public string manufacturer { get; set; }
        }
        public class SaloonCar : Car
        {
            public SaloonCar()
            {
            }

            public SaloonCar(string _numberOfSeats, string _manufacturer, string _color)
            {
                numberOfSeats = _numberOfSeats;
                manufacturer = _manufacturer;
                color = _color;
            }
            public string color { get; set; }
        }
    }
}
