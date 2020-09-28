using System;

namespace USRS1
{
    public class Input
    {
        public double ReadValue(string message)
        {
            string enter;
            double value;
            bool working = true;

            do
            {
                Console.Clear();

                if (!working)
                {
                    Console.WriteLine("Invalid...");
                }
                
                Console.Write(message);
                enter = Console.ReadLine();
                working = Double.TryParse(enter, out value);
            } while (!working);

            return value;
        }
    }
}
