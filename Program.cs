using System; // library

namespace intro // any class inside of nameespae is available
{
    class Mathematics 
    {
        // private int Add(int numOne, int numTwo)
        // {
        //     return numOne + numTwo;
        // }

        // public void AddTogether()
        // {
        //     int number = Add(10, 20);
        //     // Console.WriteLine(number);
        //     return number;
        // }
        public int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }      
        public int Sub(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }
        public int Multi(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }
        public double Div(double numOne, double numTwo)
        {
            return numOne / numTwo;
        }

        public void Nothing()
        {
            Console.WriteLine("Yo");
        }
    }

    class Program // main class
    { 
        static void Main(string[] args)
        {
            Mathematics maths = new Mathematics();
            maths.Nothing();
            double divMe = maths.Div(30, 8);
            Console.WriteLine(divMe);
            // string name = "Jacob";
            // Console.WriteLine(name);
            // maths.AddTogether();
            // int addMe = maths.Add(10, 20);
            // int subMe = maths.Sub(10, 20);
            // Console.WriteLine(addMe);
            // Console.WriteLine(subMe);
            // Console.WriteLine("Hello World!");
        }
    }
}


// open vscode
// shift + commmand + p
// shell command: install code path 
// code . in terminal initiates our project