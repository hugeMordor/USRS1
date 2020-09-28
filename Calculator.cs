using System;

namespace USRS1
{
    public class Calculator
    {
        const double G  = 6.67E-11;

        public double Calc(double mass, double radius, double height)
        {
            double sum = radius + height;
            double speed = Math.Sqrt(G*mass / sum);

            return speed;
        }
    }
}