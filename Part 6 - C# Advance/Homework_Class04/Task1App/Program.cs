using Domain;
using Domain.Classes;
using System;

namespace Task1App
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(1, 2.5f);
            Circle circle2 = new Circle(2, 4.3f);
            Circle circle3 = new Circle(3, 1.8f);


            Rectangle rectangle1 = new Rectangle(4, 5, 3.2f);
            Rectangle rectangle2 = new Rectangle(5, 4.3f, 1.2f);
            Rectangle rectangle3 = new Rectangle(6, 3, 3.6f);


            GenericDb<Circle>.ListOfObejcts.Add(circle1);
            GenericDb<Circle>.ListOfObejcts.Add(circle2);
            GenericDb<Circle>.ListOfObejcts.Add(circle3);


            GenericDb<Rectangle>.ListOfObejcts.Add(rectangle1);
            GenericDb<Rectangle>.ListOfObejcts.Add(rectangle2);
            GenericDb<Rectangle>.ListOfObejcts.Add(rectangle3);


            GenericDb<Circle>.PrintArea();
            GenericDb<Circle>.PrintPerimeter();

            Console.WriteLine("Info:");
            circle1.Info();
            rectangle1.Info();

            Console.ReadLine();
        }
    }
}
