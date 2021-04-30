using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Classes
{
    public class Rectangle : Shape
    {
        public Rectangle(int Id, float sideA, float sideB) : base(Id)
        {
            SideA = sideA;
            SideB = sideB;
        }

        public float SideA { get; set; }
        public float SideB { get; set; }

        public override float GetArea()
        {
            return SideA * SideB;
        }

        public override float GetPerimeter()
        {
            return (SideA + SideB) * 2;
        }
    }
}

