This program demonstrates encapsulation between the FactoryWorker class method AddNumbers and the Main method.
using System;

namespace Factoryworker {
    class MainClass {
        public static void Main(string[] args) {
            var worker = new FactoryWorker();
            var result = worker.AddNumbers(2, 3);

            Console.WriteLine(result.ToString());

        }
    }
    public class FactoryWorker {
        public FactoryWorker() {

        }

        //We use int instead of void because we are going to be returning an integer from this method
        public int AddNumbers(int num1, int num2) {
            // * Encapsulation / Data hiding simplifies the build process for progrmming.
            //It doesn't matter what is done here to get the result, as long as it returns the same result to main.
            var result = num1 + num2;
            result = result + 100;
            result = result - 100;
            return result;
        }

    }
}
