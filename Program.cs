using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Here are some examples of variables in c#

            //This creates an integer with the name myNum and sets it to 5
            //Int is the type given to the variable. It is important to declare what type the variable is in c# as c# is a strict typed language
            public int myNum = 5;

            //Functions in c# are very similar to those in javascript. The main difference is that in c# the function must be given the data type that will be returned when the function finishes.
            //Also, any parameters must have their type defined as well.
            //This function is declared to return an integer value. It will accept two integers as its parameters
            int AddNumbers(int numA, int numB){
                int answer = numA + numB;
                return answer;
            }

            //Functions that don't return anything need to be typed with void
            //This function takes an integer and writes it to the console, but nothing gets returned
            void writeNumber(int num){
                Console.WriteLine(num);
            }
        }
    }
}
