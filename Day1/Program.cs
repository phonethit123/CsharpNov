using System;

namespace Day1
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ITC");

            string name = "Ko Phyu";

            byte age = 18;
            byte days = 31;

            Console.WriteLine(age);
            Console.WriteLine(days);

            double dou = 10.123;
            float flo = 10.123f;
            decimal dec = 10.123m;

            Console.WriteLine(dou);
            Console.WriteLine(flo);
            Console.WriteLine(dec);

            bool bo = true;
            Console.WriteLine(bo); 
            
            DateTime date = DateTime.Now;
            Console.WriteLine(date.ToString("MM/dd/yyyy"));


        }
    }
}
