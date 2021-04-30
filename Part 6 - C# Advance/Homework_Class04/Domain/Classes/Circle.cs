using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Classes
{
    public class Circle : Shape
    {
        public float Radius { get; set; }


        public Circle(int id, float radius) : base(id)
        {
            Radius = radius;
        }

        public override float GetArea()
        {
            return MathF.PI * (Radius * Radius);
        }

        public override float GetPerimeter()
        {
            return 2 * MathF.PI * Radius;
        }
    }
}