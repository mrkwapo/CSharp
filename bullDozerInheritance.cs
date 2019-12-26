//This program demonstrates inheretance
using System;

namespace Bulldozer {
    class Program {
        public static void Main(string[] args) {
          //Instatiating
            var man = new Man();
            var kart = new Kart();
            var alien = new Alien();

            // Assigning properties through inheretance
            alien.color = "Yellow";
            man.color = "Black";
            alien.color = "Green";
        }
    }

    //Created a new object which holds common properties of man, alien and kart.
    public class GeneralObject {
        public GeneralObject() {
        }
        public bool moves { get; set; }
        public string color { get; set; }
}

//The Man object has its own "name" property but inherits moves and color from "GeneralObject"
public class Man : GeneralObject
{
        
        public Man() {
    }

        public string name { get; set; }
}

//The Kart object has its own "manufacturer" property but inherits moves and color from "GeneralObject"
public class Kart : GeneralObject
{
        public Kart() {
    }
        public string manufacturer { get; set; }


}

//The Alien object has its own "planet" property but inherits moves and color from "GeneralObject"
public class Alien : GeneralObject
{
        public Alien()
    {
    }
        public string planet { get; set; }


}
}
