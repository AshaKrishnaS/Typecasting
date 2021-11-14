using System;

namespace typecasting
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 2;
            double myDouble = 32.99;
            bool myBool = false;
            Console.WriteLine(Convert.ToString(myBool));
            Console.WriteLine(Convert.ToInt32(myDouble));
            Console.WriteLine(Convert.ToDouble(myInt));

        }
    }
}
