using System;

namespace intro
{
    class AgeCalculator
    {
        public void Calculator(int age)
        {
            //int age = 29;
            if (age < 18)
                Console.WriteLine("James0, what0?");
            else if (age < 40)
                Console.WriteLine("Seriously0, James0?");
            else if (age < 65)
                Console.WriteLine("Oh0, James0");
            else
                Console.WriteLine("Thank God0, This is over0");
        }
    }
}