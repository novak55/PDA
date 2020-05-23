using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UkolB4
{
    class Point
    {
        double x = 0.0;
        double y = 0.0;

        public void SetX(double x) { this.x = x; }
        public void SetY(double y) { this.y = y; }

        public double GetX() { return this.x; }
        public double GetY() { return this.y; }
    }
}
