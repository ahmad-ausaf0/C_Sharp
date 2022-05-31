using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // int num1 , num2, sum;
            // Console.WriteLine("Enter two numbers for sum : ");
            // num1 = int.Parse(Console.ReadLine());
            // num2 = int.Parse(Console.ReadLine());
            // sum = num1 + num2;
            // // string output = String.Format("The sum of {0} and {1} is: " + (num1, num2, sum));
            // Console.WriteLine("The sum is : " + sum);
            Console.Write("Enter number to compute multiplication table : ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++) {
                Console.WriteLine(x + "x" + i + "=" + (x*i));
            }
            // bool boolVal = true;
            // float floatVal;
            // floatVal = Convert.ToSingle(boolVal);
            // Console.WriteLine(floatVal);
        }
    }

}
