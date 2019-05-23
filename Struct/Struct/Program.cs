using System;

namespace Struct {
    class Program {
        static void Main(string[] args) {
            Point p;

            p.x = null;
            p.y = 20;

            Console.WriteLine(p);
            Console.WriteLine(p.x.HasValue);
            Console.WriteLine(p.y.HasValue);
            p = new Point();

            Console.WriteLine(p);


            double? x1 = null;

            double x2;

            x2 = x1 ?? 0;

            Console.WriteLine(x2);

            
        }
    }
}
