using System.Collections.Generic;
using System.Text;

namespace Domain.Classes
{
    public abstract class Shape
    {
        public int Id { get; set; }

        public Shape(int id)
        {
            Id = id;
        }


        public abstract float GetArea();

        public abstract float GetPerimeter();

    }
}

