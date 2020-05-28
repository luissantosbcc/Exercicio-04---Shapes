using System;
using System.Collections.Generic;
using System.Globalization;
using Program.Entities;
using Program.Entities.Enums;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.WriteLine("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{1} data: ");
                Console.WriteLine("Rectangle or circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine("Color (black,blue,red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (ch == 'r')
                {
                    Console.WriteLine("Widht: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, height, color));
                }
                else {
                    Console.WriteLine("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }                
            }

            Console.WriteLine();
            Console.WriteLine("Shapes Areas: ");
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
