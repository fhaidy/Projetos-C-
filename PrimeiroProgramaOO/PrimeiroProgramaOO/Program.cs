using System;
using System.Globalization;

namespace PrimeiroProgramaOO {
    class Program {
        static void Main(string[] args) {

            Triangulo trianguloX = new Triangulo();

            Console.WriteLine("Digite as medidas do triangulo X:");
            trianguloX.LadoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            trianguloX.LadoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            trianguloX.LadoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Triangulo trianguloY = new Triangulo();

            Console.WriteLine("Digite as medidas do triangulo Y:");
            trianguloY.LadoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            trianguloY.LadoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            trianguloY.LadoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double areaX = trianguloX.CalcularArea();

            double areaY = trianguloY.CalcularArea();

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY) {
                Console.WriteLine("A maior área é a de X");
            } else if (areaY > areaX) {
                Console.WriteLine("A maior área é a de Y");
            } else {
                Console.WriteLine("As áreas são iguais");
            }
        }
    }
}
