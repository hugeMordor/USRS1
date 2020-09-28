using System;

namespace USRS1
{
    class Sputnik
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Input input = new Input();

            double mass = input.ReadValue("Enter Mass Of Planet: ");
            double radius = input.ReadValue("Enter Radius of Planet: ");
            double height = input.ReadValue("Enter Height Above Surface: ");

            Console.Write("Speed = ");
            Console.WriteLine(calculator.Calc(mass, radius, height));
        }
    }
}