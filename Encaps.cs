using System;

namespace intro
{
    class Encaps
    {
        private string name;
        private string nickname;
        private string location;
        private string jobtitle;
        private double salary;
        public void Info()
        {
            name = "Ebuka";
            nickname = "Bubu";
            location = "Manchester";
            jobtitle = "Software Dev";
            salary = 100000;
            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"Everyone calls me {nickname}");
            Console.WriteLine($"From {location}");
            Console.WriteLine($"I work as a {jobtitle}");
            Console.WriteLine($"I get paid {salary} for my services");
        }
    }
}