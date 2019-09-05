using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace console_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = 0, n2 = 0, result = 0;
            Console.WriteLine("console calculator");
            Console.WriteLine("enter 1st number");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter choice");
            Console.WriteLine("Press + for Addition");
            Console.WriteLine("Press - for Subtraction");
            Console.WriteLine("Press * for Multiplication");
            Console.WriteLine("Press / for Division");
            Console.WriteLine("Press m for modulus");
            Console.WriteLine("Press % for percentage");
            Console.WriteLine("Press r for square root");
            Console.WriteLine("Press ^ for power");
            char ch = Console.ReadKey().KeyChar;
            switch (ch)
            {
                case '+':
                    Console.WriteLine("\n enter 2nd number");
                    n2 = Convert.ToDouble(Console.ReadLine());
                    result = Addition(n1, n2);
                    break;
                case '-':
                    Console.WriteLine("\n enter 2nd number");
                    n2 = Convert.ToDouble(Console.ReadLine());
                    result = Subtraction(n1, n2);
                    break;
                case '*':
                    Console.WriteLine("\n enter 2nd number");
                    n2 = Convert.ToDouble(Console.ReadLine());
                    result = Multiplication(n1, n2);
                    break;
                case '/':
                    Console.WriteLine("\n enter 2nd number");
                    n2 = Convert.ToDouble(Console.ReadLine());

                    result = Division(n1, n2);
                    break;
                case 'm':
                    Console.WriteLine("\n enter 2nd number");
                    n2 = Convert.ToDouble(Console.ReadLine());
                    result = Modulus(n1, n2);
                    break;
                case '%':
                    Console.WriteLine("\n enter 2nd number");
                    n2 = Convert.ToDouble(Console.ReadLine());
                    result = Percentage(n1, n2);
                    break;
                case 'r': //Console.WriteLine("enter 2nd number");
                    //n2 = Convert.ToDouble(Console.ReadLine());
                    result = Square_root(n1);
                    break;
                case '^':
                    Console.WriteLine("\n enter 2nd number");
                    n2 = Convert.ToDouble(Console.ReadLine());
                    result = Power(n1, n2);
                    break;
                default:
                    Console.WriteLine("\n wrong choice");
                    break;

            }
            Console.WriteLine("\n result= {0}", Math.Round(result, 2));
            Console.ReadKey();
        }
        //Addition
        public static double Addition(double n1, double n2)
        {
            double result = n1 + n2;
            return result;
        }
        //Subtraction
        public static double Subtraction(double n1, double n2)
        {
            double result = n1 - n2;
            return result;
        }
        //Multiplication
        public static double Multiplication(double n1, double n2)
        {
            double result = n1 * n2;
            return result;
        }
        //Division
        public static double Division(double n1, double n2)
        {
            double result = n1 / n2;
            return result;
        }
        //Modulus
        public static double Modulus(double n1, double n2)
        {
            double result = n1 % n2;
            return result;
        }
        //Percentage
        public static double Percentage(double n1, double n2)
        {
            double result = n1 / 100 * n2;
            return result;
        }
        //Square_root
        public static double Square_root(double n1)
        {
            double result = Math.Sqrt(n1);
            return result;
        }
        //Power
        public static double Power(double n1, double n2)
        {
            double result = Math.Pow(n1, n2);
            return result;
        }
    }
}