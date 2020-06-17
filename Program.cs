using System; // library

namespace intro // any class inside of nameespae is available
{
    class Mathematics
    {
        private double Add(double numOne, double numTwo)
        {
            return numOne + numTwo;
        }

        public double AddTogether()
        {
            double number = Add(14.50, 76.30);
            Console.WriteLine(number);
            return number;
        }
        public int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }
        public float Sub(float numOne, float numTwo)
        {
            return numOne - numTwo;
        }
        public decimal Multi(decimal numOne, decimal numTwo)
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
            // Mathematics maths = new Mathematics();
            // AgeCalculator checkAge = new AgeCalculator();
            Encaps example = new Encaps();
            example.Info();
            // Console.Write("Enter name: ");
            // string name = Console.ReadLine();
            // example.name = Console.ReadLine();
            //example.name = name;
            //example.salary = 09000;
            // Console.WriteLine();
            // intro.Mathematics maths = new Mathematics();
            // intro.AgeCalculator checkAge = new AgeCalculator();
            // Console.Write("Enter age: ");
            // string userInput = Console.ReadLine();
            // string naomi = "hello";
            // Console.WriteLine("The user said they were {0}. {1}", userInput, naomi);
            // Console.WriteLine($"The user said they were {userInput}. {naomi}");
            // Console.WriteLine("The user said they were " + userInput + ". " + naomi + ".");
            // checkAge.Calculator(Convert.ToInt32(userInput));
            // checkAge.Calculator(Int32.Parse(userInput));
            // checkAge.Calculator(70);
            // maths.AddTogether();
            // maths.Nothing();
            // double addMe = maths.Add()
            // float subMe = maths.Sub(10.333f, 3f);
            // decimal multiMe = maths.Multi(35.45m, 67.98m);
            // double divMe = maths.Div(30, 8);
            // Console.WriteLine(subMe);
            // Console.WriteLine(multiMe);
            // Console.WriteLine(divMe);
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