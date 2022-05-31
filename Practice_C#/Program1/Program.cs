using System;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            // double avg;
            // int  n, sum_p = 0, total;
            // Console.Write("Enter total number to calculate average: ");
            // total = int.Parse(Console.ReadLine());
            // for (int i = 1; i <= total; i++) {
            //     Console.Write("Number {0} is: ", i);
            //     n = int.Parse(Console.ReadLine());
            //     if ( n > 0) {
            //         sum_p = sum_p + n;
            //     }
                 
            // }
            // avg = sum_p / total;
            // Console.Write("The sum of {0} numbers is : {1}\nThe Average is : {2}\n" ,total,sum_p,avg);
            float[] numbers = new float[10];
            float totalPositive = 0.0;
            float totalNegative = 0.0;
            int countPositive = 0;
            int countNegative = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Number {0}= ",i);
                numbers[i] = Convert.ToSingle( Console.ReadLine());
            }

            for (int i = 1; i <= 10; i++)
            {   
                //Negative
                if (numbers[i] < 0) 
                {
                    totalNegative = totalNegative + numbers[i];
                    countNegative++;
                }
        

                //Positive
                if (numbers[i] > 0) 
                {
                    totalPositive = totalPositive + numbers[i];
                    countPositive++;
                }
            }
            
            Console.WriteLine("Average numbers negatives = {0}",totalNegative / countNegative);
            Console.WriteLine("Average numbers positives = {0}",totalPositive / countPositive);  
        }
    }
}
