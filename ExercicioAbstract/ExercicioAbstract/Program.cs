using System;
using System.Globalization;
using System.Collections.Generic;
using ExercicioAbstract.Entities;
using ExercicioAbstract.Entities.Enums;

namespace ExercicioAbstract {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter the number of shapes: ");
            int count = int.Parse(Console.ReadLine());
            List<Shape> list = new List<Shape>();


            for (int i = 1; i <= count ; i++) {
                Console.WriteLine($"Shape #{i} data: ");

                Console.Write("Circle or Rectangle (c/r)?");
                char ch = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Color (Black/Blue/Red):");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if(ch == 'r') {
                    Console.Write("Width:");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Rectangle(color, width, height));
                }else if(ch == 'c') {
                    Console.Write("Radius:");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(color, radius));
                }
            }
            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS: ");
            foreach(Shape shape in list) {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
