//This program demonstrates polymorphism in which the factory worker is assigned 2 methods "Count" to handle adding two types: ints and floats.
using System;

namespace Factoryworker {
    class MainClass {
        public static void Main(string[] args) {
            var worker = new FactoryWorker();
            worker.Count(4);
            worker.Count(5);

            worker.Count(4.5f);
        }
    }
    public class FactoryWorker {
        public FactoryWorker() {

        }

        //giving this class a method
        //This method is called only when a float is passed in as an argument in the Count method
        public void Count(int number) {
            if (Total == null)
                Total = 0;
            //Conver.ToSingle converts the into to a float so that we may add the Float, total and Integer, number
            Total = Total + Convert.ToSingle(number);
            Console.WriteLine(Total.ToString());
        }

        //Only in relation to polymorphism do we reuse method names. Notice we are using a different type of varible 
        //This method is called only when a float is passed in as an argument in the Count method 
        public void Count(float number) {
            Total = Total + number;
            Console.WriteLine(Total.ToString());
        }

        //creating a class variable that is a float because floats can handle ints
        public float Total { get; set; }
}
}
