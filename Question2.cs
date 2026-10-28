// Test inputs used in output.png:
//   Test 1: 6000  -> 20% discount, 1200 discount, 4800 payable
//   Test 2: 1500  -> 0% discount (no discount)
//   (optional) 3000 -> 10% discount
using System;

class Question2
{
    static void Main()
    {
        // 1st line of output: ClassID, Registration ID, Name, Date
        string classId = "121183";
        string regId = "66409";
        string name = "Syed Muhammad Hasnain Abdi";
        string submissionDate = "28-10-2026";
        Console.WriteLine($"ClassID: {classId} | Reg ID: {regId} | Name: {name} | Date: {submissionDate}");

        Console.Write("Enter purchase amount: ");

        // Validate input: must be a non-negative number
        if (!double.TryParse(Console.ReadLine(), out double amount) || amount < 0)
        {
            Console.WriteLine("Invalid amount");
            return;
        }

        double discountPercent;

        // Decide discount percentage based on amount
        if (amount >= 5000)
            discountPercent = 20;
        else if (amount >= 2000)   // amount is 2000 to 4999
            discountPercent = 10;
        else
            discountPercent = 0;

        double discountAmount = amount * discountPercent / 100;
        double finalAmount = amount - discountAmount;

        Console.WriteLine($"Discount Percentage: {discountPercent}%");
        Console.WriteLine($"Discount Amount: {discountAmount}");
        Console.WriteLine($"Final Payable Amount: {finalAmount}");
    }
}
