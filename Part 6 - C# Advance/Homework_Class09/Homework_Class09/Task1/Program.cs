using System;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine(currentDirectory);

            string appPath = @"..\..\..\";
            string folderPath = appPath + @"\Exercise\";
            string filePath = folderPath + @"calculations.txt";

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                Console.WriteLine("New directory was created!");
            }

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            int counter = 1;
            while (true)
            {
                if (counter == 4)
                {
                    break;
                }

                Console.WriteLine(counter+".");
                Console.WriteLine("Enter the first number");
                string firstNum = Console.ReadLine();
                bool success1 = int.TryParse(firstNum, out int numberOne);

                Console.WriteLine("Enter the second number");
                string secondNum = Console.ReadLine();
                bool success2 = int.TryParse(secondNum, out int numberTwo);
                Console.WriteLine("");

                if (success1 && success2)
                {
                    string res = AdditionTwoNumbers(numberOne, numberTwo);
                    using (StreamWriter sw = new StreamWriter(filePath, true))
                    {
                        sw.WriteLine(res);
                        sw.WriteLine(DateTime.Now.ToString("MM/dd/yyyy HH:mm"));
                        sw.WriteLine("");
                        Console.WriteLine(counter+ ". completed");
                        counter++;
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Incorect inputs, try again.");
                }
            }



            Console.ReadLine();
        }

        public static string AdditionTwoNumbers(int num1, int num2)
        {
            int result = num1 + num2;
            return $"{num1} + {num2} = {result}";
        }
    }
}
