using System;
namespace PrimeiroProgramaOO {
    class Triangulo {

        public double LadoA;
        public double LadoB;
        public double LadoC;

        public double CalcularArea() {
            double p = (LadoA + LadoB + LadoC) / 2.0;
            return Math.Sqrt(p * (p - LadoA) * (p - LadoB) * (p - LadoC)); ;

        }

    }
}
