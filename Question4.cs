// Test inputs used in output.png:
//   Test 1: 10, 5, +   -> 10 + 5 = 15
//   Test 2: 8, 0, /    -> Error: Division by zero
//   (optional) 4, 2, % -> Invalid operator
using System;

class Question4
{
    static void Main()
    {
        // 1st line of output: ClassID, Registration ID, Name, Date
        string classId = "121183";
        string regId = "66409";
        string name = "Syed Ahsan Rizvi";
        string submissionDate = "28-10-2026";
        Console.WriteLine($"ClassID: {classId} | Reg ID: {regId} | Name: {name} | Date: {submissionDate}");

        Console.Write("Enter first number: ");
        bool ok1 = double.TryParse(Console.ReadLine(), out double num1);
        Console.Write("Enter second number: ");
        bool ok2 = double.TryParse(Console.ReadLine(), out double num2);

        if (!ok1 || !ok2)
        {
            Console.WriteLine("Invalid number");
            return;
        }

        Console.Write("Enter operator (+, -, *, /): ");
        string opInput = Console.ReadLine();
        char op = string.IsNullOrEmpty(opInput) ? ' ' : opInput[0];

        // switch performs the operation for the chosen operator
        switch (op)
        {
            case '+': Console.WriteLine($"{num1} + {num2} = {num1 + num2}"); break;
            case '-': Console.WriteLine($"{num1} - {num2} = {num1 - num2}"); break;
            case '*': Console.WriteLine($"{num1} * {num2} = {num1 * num2}"); break;
            case '/':
                if (num2 == 0)
                    Console.WriteLine("Error: Division by zero");
                else
                    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                break;
            default:
                Console.WriteLine("Invalid operator");
                break;
        }
    }
}
