// Test inputs used in output.png:
//   Test 1: 2024 -> Leap year
//   Test 2: 1900 -> Not a leap year (divisible by 100 but not 400)
//   (optional) 2000 -> Leap year, 2023 -> Not a leap year
using System;

class Question3
{
    static void Main()
    {
        // 1st line of output: ClassID, Registration ID, Name, Date
        string classId = "121183";
        string regId = "66409";
        string name = "Syed Ahsan Rizvi";
        string submissionDate = "28-10-2026";
        Console.WriteLine($"ClassID: {classId} | Reg ID: {regId} | Name: {name} | Date: {submissionDate}");

        Console.Write("Enter a year: ");

        if (!int.TryParse(Console.ReadLine(), out int year) || year <= 0)
        {
            Console.WriteLine("Invalid year");
            return;
        }

        bool isLeap;

        // Divisible by 400 -> leap (exception to the 100 rule)
        if (year % 400 == 0)
            isLeap = true;
        // Divisible by 100 (but not 400) -> not leap
        else if (year % 100 == 0)
            isLeap = false;
        // Divisible by 4 -> leap
        else if (year % 4 == 0)
            isLeap = true;
        else
            isLeap = false;

        Console.WriteLine(isLeap ? $"{year} is a Leap Year" : $"{year} is NOT a Leap Year");
    }
}
