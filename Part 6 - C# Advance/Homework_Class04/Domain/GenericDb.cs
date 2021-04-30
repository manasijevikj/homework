using Domain.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public static class GenericDb<T> where T : Shape
    {
        public static List<T> ListOfObejcts;

        static GenericDb()
        {
            ListOfObejcts = new List<T>();
        }

        public static void PrintArea()
        {
            Console.WriteLine("Areas:");
            foreach (T t in ListOfObejcts)
            {
                Console.WriteLine($"No {ListOfObejcts.IndexOf(t) + 1}: {Math.Round(t.GetArea(), 2)}");
            }
        }

        public static void PrintPerimeter()
        {
            Console.WriteLine("Perimeters:");
            foreach (T t in ListOfObejcts)
            {
                Console.WriteLine($"No {ListOfObejcts.IndexOf(t) + 1}: {Math.Round(t.GetPerimeter(), 2)}");
            }
        }
    }
}