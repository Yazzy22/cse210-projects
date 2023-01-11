using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userAnswer = -1;
        int sum = 0;
        double average = 0;
        int max = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (userAnswer != 0)
        {
            Console.Write("Enter number: ");
            string number = Console.ReadLine();
            userAnswer = int.Parse(number);
            if (userAnswer != 0)
            {
                numbers.Add(userAnswer);
            }
            else
            {
                Console.WriteLine("Thank you");
            }
            sum += userAnswer;
        }
        Console.WriteLine($"The sum is: {sum}");
        double items = numbers.Count;
        average = sum/items;
        Console.WriteLine($"The average is {average}");
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");
    }
}