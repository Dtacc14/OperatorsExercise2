using System;

namespace OperatorsExercise2
{
    internal class Program
    {
        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        static string Add(int num1, int num2, bool money)
        {
            var sum = num1 + num2;
            if (money == true && sum > 1)
            {
                return $"You have {sum} dollars!";
            }
            else if (money == true && sum == 1)
            {
                return $"you have {sum} dollar!";
            }
            else if (money == true && sum < 1)
            {
                return $"you have {sum} dollars!";
            }
            else
            {
                return sum.ToString();
            }
        }

        static string Add(params int[] numbers)
        
        {
            int sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            return sum.ToString();
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(15, 30));
            Console.WriteLine(Add(24.35, 57.65));
            Console.WriteLine(Add(100, 50, true));
            Console.WriteLine(Add(5, 8, 3, 6, 8));
        }
    }
}
