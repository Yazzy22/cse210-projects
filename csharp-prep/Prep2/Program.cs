using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string valueFromUser = Console.ReadLine();

        int grade = int.Parse(valueFromUser);
        
        // Strech Challenge 1
        string gradeSing = "";
        int lastDigit = grade % 10;

        if (lastDigit >= 7)
        {
            gradeSing = "+";
        }
        else if (lastDigit < 3)
        {
            gradeSing = "-";
        }
        else
        {
            gradeSing = "";
        }

        //Stretch Challenges 2 and 3
        if (grade >= 93 || grade < 60)
        {
            gradeSing = "";
        }
        

        if (grade >= 90)
        {
            Console.WriteLine($"Your letter grade is A{gradeSing}");
        }
        else if (grade >= 80)
        {
            Console.WriteLine($"Your letter grade is B{gradeSing}");
        }
        else if (grade >= 70)
        {
            Console.WriteLine($"Your letter grade is C{gradeSing}");
        }
        else if (grade >= 60)
        {
            Console.WriteLine($"Your letter grade is D{gradeSing}");
        }
        else 
        {
            Console.WriteLine($"Your letter grade is F{gradeSing}");
        }

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You have passed the course!! ");
        }
        else 
        {
            Console.WriteLine("Do not worry, just keep studying!");
        }

    }
        
}