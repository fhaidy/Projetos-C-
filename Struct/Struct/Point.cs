using System;
using System.Collections.Generic;
using System.Text;

namespace Struct {
    struct Point {

        public double? x, y;


        public override string ToString() {
            return "(" + x.GetValueOrDefault() + ", " + y.GetValueOrDefault() + ")";
        }

    }
}
