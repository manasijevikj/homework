using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a number 1:");
            string numberOne = Console.ReadLine();
            bool numberOneSuccess = int.TryParse(numberOne, out int numberOneParsed);

            Console.WriteLine("Insert a number 2:");
            string numberTwo = Console.ReadLine();
            bool numberTwoSuccess = int.TryParse(numberTwo, out int numberTwoParsed);

            Console.WriteLine("Insert operand:");
            string operand = Console.ReadLine();

            if (numberOneSuccess && numberTwoSuccess)
            {
                Calculator(operand, numberOneParsed, numberTwoParsed);
            }
            else
            {
                Console.WriteLine("Values are not numbers!");
            }

            Console.ReadLine();
        }

        public static int Sum(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        public static int Substract(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }

        public static int Multiplication(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }

        public static int Division(int num1, int num2)
        {
            int result = num1 / num2;
            return result;
        }

        public static void Calculator(string operand, int num1, int num2)
        {
            int result;

                switch (operand) { 
            
                case "+":
                    result = Sum(num1, num2);
                    Console.WriteLine("The sum of "+num1+" and "+num2+" is "+ result);
                    break;
                case "-":
                    result = Substract(num1, num2);
                    Console.WriteLine("The substract of " + num1 + " and " + num2 + " is " + result);
                    break;
                case "*":
                    result = Multiplication(num1, num2);
                    Console.WriteLine("The multiolication of " + num1 + " and " + num2 + " is " + result);
                    break;
                case "/":
                    result = Division(num1, num2);
                    Console.WriteLine("The division of " + num1 + " and " + num2 + " is " + result);
                    break;

                default:
                    Console.WriteLine("Incorrect operand");
                    break;
                }
        }


    }
}
