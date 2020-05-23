using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UkolB4
{
    class ZpracujBod
    {
        double vzdalenost = 0.0, stupen = 0.0, radian = 0.0;
        string kvadrant = "nedef.";
        Point bod;

        public ZpracujBod(Point bod)
        {
            this.bod = bod;
            SpoctiKvadant();
            SpoctiVzdalenost();
            SpoctiRad();
            SpoctiStupen();
        }

        private void SpoctiKvadant() {
            if (bod.GetX() >= 0 && bod.GetY() >= 0) { this.kvadrant = "I."; }
            else if (bod.GetX() <= 0 && bod.GetY() >= 0) { kvadrant = "II."; this.radian = Math.PI / 2; }
            else if (bod.GetX() <= 0 && bod.GetY()  <= 0) { kvadrant = "III."; this.radian = Math.PI * 3 / 2; }
            else { kvadrant = "IV."; this.radian = Math.PI * 2; }
        }

        private void SpoctiVzdalenost()
        {
            this.vzdalenost = Math.Sqrt(Math.Pow(bod.GetX(), 2) + Math.Pow(bod.GetY(), 2));
        }

        private void SpoctiRad()
        {
            this.radian += Math.Asin(bod.GetY() / vzdalenost);
        }

        private void SpoctiStupen()
        {
            this.stupen = this.radian * 180 / Math.PI;
        }

        public double GetVzdalenost() { return this.vzdalenost; }
        public double GetStupen() { return this.stupen; }
        public double GetRadian() { return this.radian; }
        public string GetKvadrant() { return this.kvadrant; }
    }
}
