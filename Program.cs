using System;

namespace Calculator_.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");
            Console.WriteLine("testing, testing, does this show?");*/
            string firstQuestion = "What is your first Number?";
            string secondQuestion = "What is your second Number?";
            
            
            Console.WriteLine(firstQuestion);
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(secondQuestion);
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What would you like to do with the numbers?");
            Console.WriteLine("\t1 - Addition");
            Console.WriteLine("\t2 - Subtraction");
            Console.WriteLine("\t3 - Multiply");
            Console.WriteLine("\t4 - Divide");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Result is: " + firstNumber + secondNumber);
                    break;
                case "2":
                    Console.WriteLine("Result is: " + (firstNumber - secondNumber));
                    break;
                case "3":
                    Console.WriteLine("Result is: " + firstNumber * secondNumber);
                    break;
                case "4":
                    Console.WriteLine("Result is: " + firstNumber / secondNumber);
                    break;
            }
            
        }
    }
}