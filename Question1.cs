// Test inputs used in output.png:
//   Test 1 (valid)  : 3     -> Wednesday
//   Test 2 (invalid): 9     -> Invalid number
using System;

class Question1
{
    static void Main()
    {
        // 1st line of output: ClassID, Registration ID, Name, Date
        string classId = "121183";
        string regId = "66409";
        string name = "Syed Muhammad Hasnain Abdi";
        string submissionDate = "28-10-2026";
        Console.WriteLine($"ClassID: {classId} | Reg ID: {regId} | Name: {name} | Date: {submissionDate}");

        Console.Write("Enter day number (1-7): ");
        string input = Console.ReadLine();

        // Not a number -> invalid
        if (!int.TryParse(input, out int day))
        {
            Console.WriteLine("Invalid number");
            return;
        }

        // switch selects the day name; default handles numbers outside 1-7
        switch (day)
        {
            case 1: Console.WriteLine("Monday"); break;
            case 2: Console.WriteLine("Tuesday"); break;
            case 3: Console.WriteLine("Wednesday"); break;
            case 4: Console.WriteLine("Thursday"); break;
            case 5: Console.WriteLine("Friday"); break;
            case 6: Console.WriteLine("Saturday"); break;
            case 7: Console.WriteLine("Sunday"); break;
            default: Console.WriteLine("Invalid number"); break;
        }
    }
}
