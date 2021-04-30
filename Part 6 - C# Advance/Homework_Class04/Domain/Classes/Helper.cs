using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Classes
{
    public static class Helper
    {
        public static void Info<T>(this T t) where T : Shape
        {
            Console.WriteLine($"ID: {t.Id}");
        }
    }
}
