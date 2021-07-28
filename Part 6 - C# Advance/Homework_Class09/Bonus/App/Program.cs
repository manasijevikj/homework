using Domain.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace App
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\People";
            string filePath = folderPath + @"\peopleList.txt";

            List<Person> people = new List<Person>()
            {
                new Person("Paul","Paulsky", 20),
                new Person("Bob", "Bobsky", 30)
            };


            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            WritePeople(filePath, people);

            List<Person> newPeopleList = ReadPeople(filePath, people);
            Console.WriteLine("Copy of the list of people:");
            foreach (Person person in newPeopleList)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName} {person.Age}");
            }

            Console.ReadLine();
        }

        public static void WritePeople(String filePath, List<Person> people)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (Person person in people)
                {
                    sw.WriteLine($"{person.FirstName} {person.LastName} {person.Age}");
                }
                Console.WriteLine("All people are written in the file");
            }
        }

        public static List<Person> ReadPeople(String filePath, List<Person> people)
        {
            List <Person> newPeople = new List<Person>();
            using (StreamReader sr = new StreamReader(filePath))
            {
                for (int i = 0; i < people.Count; i++)
                {
                    string personFromTxt = sr.ReadLine();
                    string[] personFromTxtSplit = personFromTxt.Split(" ");
                    Person tempPerson = new Person(personFromTxtSplit[0], personFromTxtSplit[1], int.Parse(personFromTxtSplit[2]));
                    newPeople.Add(tempPerson);
                }
            }
            return newPeople;
        }
        


    }
}
