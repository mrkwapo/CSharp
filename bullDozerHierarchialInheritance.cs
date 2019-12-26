//This program demonstrates establishing a hierarchy of inheritance so that one object can inherit from multiple obects
using System;

namespace Bulldozer {
    class Program {
        public static void Main(string[] args) {
            var man = new Man();
            var kart = new Kart();
            var alien = new Alien();
        }
    }

    public class GeneralObject {
        public GeneralObject() {
        }
        public bool moves { get; set; }
        public string color { get; set; }
}

//Hierarchial Inheritance: Human object is inheriting properties from GeneralObject. And Man and Woman objects inherit GeneralObject properties through the Human Object
public class Human : GeneralObject
{
        public Human(){
    }
        public string name { get; set; }
}

public class Woman : Human
{
        public Woman()
    {

    }
}
public class Man : Human
{
        
        public Man() {
    }
}

public class Kart : GeneralObject
{
        public Kart() {
    }
        public string manufacturer { get; set; }


}

public class Alien : GeneralObject
{
        public Alien()
    {
    }
        public string planet { get; set; }


}
}
