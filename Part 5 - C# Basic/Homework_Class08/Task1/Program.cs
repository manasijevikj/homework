using System;
using System.Collections;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                MainFunction();

                Start:
                Console.WriteLine("If you want to do it again enter Y. If you want to exit enter N.");
                string answer = Console.ReadLine();

                if(answer.ToLower() == "y")
                {
                    continue;
                }
                else if(answer.ToLower() == "n") {
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect answer.");
                    goto Start;
                }
            }
            while (true);
            Console.ReadLine();
        }

        public static void MainFunction()
        {
            Queue resultQueue;
            while (true)
            {
                Console.WriteLine("Insert a number of inputs:");
                string number = Console.ReadLine();
                bool numberSuccess = int.TryParse(number, out int numberParsed);

                if (!numberSuccess)
                {
                    Console.WriteLine("Wrong input. Please try again.");
                }
                else
                {
                    resultQueue = InsertNumbers(numberParsed);
                    break;
                }
            }
            PrintQueue(resultQueue);
        }

        public static Queue InsertNumbers(int n)
        {
            int counter = 0;
            Queue inputsQueue = new Queue();

            while(counter<n)
            {
                Console.WriteLine($"Insert a number {counter+1}: ");
                string number = Console.ReadLine();
                bool numberSuccess = int.TryParse(number, out int numberParsed);

                if(numberSuccess)
                {
                    inputsQueue.Enqueue(numberParsed);
                    counter++;
                }
                else
                {
                    Console.WriteLine("The input is not a number. Try again.");
                }
            }

            return inputsQueue;
        }

        public static void PrintQueue(Queue queue)
        {
            Console.WriteLine("All the numbers in the entered order are:");
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}
