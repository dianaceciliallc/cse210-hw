using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string grade = Console.ReadLine();

        int percentage = int.Parse(grade);
        string letter = "";
        string sign = "";

        if ( percentage >= 90 )
        {
            letter = "A";
        }
        else if ( percentage >= 80 )
        {
            letter = "B";
        }
        else if ( percentage >= 70 )
        {
            letter = "C";
        }
        else if ( percentage >= 60 )
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int lastDigit = percentage % 10;

        if ( lastDigit >= 7)
        {
            sign = "+";
        }
        else if ( lastDigit < 3 )
        {
            sign = "-";
        }

        if ( (letter == "A" && sign == "+") || letter == "F")
        {
            sign = "";
        }

        Console.WriteLine($"Your letter grade is {letter}{sign}.");

        if ( percentage >=70 )
        {
            Console.WriteLine("Congratulations! You did a fantastic job.");
        }
        else
        {
            Console.WriteLine("Don't give up! Keep practicing and you will get it next time.");
        }
    }
}