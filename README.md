# CSharp-Conditional-Statements

**Assignment 1 – C# Conditional Statements**

| | |
|---|---|
| **Name** | Syed Muhammad Hasnain Abdi |
| **Class ID** | 121183 |
| **Registration ID** | 66409 |
| **Submission Date** | 28-10-2026 |

Each program prints ClassID, Registration ID, Name and Date as the first line of output.

## Folder Structure

```
CSharp-Conditional-Statements/
├── Question1/  (Question1.cs, flowchart.png, output.png)
├── Question2/  (Question2.cs, flowchart.png, output.png)
├── Question3/  (Question3.cs, flowchart.png, output.png)
└── Question4/  (Question4.cs, flowchart.png, output.png)
```

## Question 1 – Day Name from Number
Reads a number (1–7) and prints the day name. Anything else prints `Invalid number`.
Concepts: `switch`, `int.TryParse`

| Input | Output |
|---|---|
| 3 | Wednesday |
| 9 | Invalid number |

## Question 2 – Shop Discount
Discount: ≥ 5000 → 20%, 2000–4999 → 10%, otherwise 0%. Prints discount %, discount amount and final payable amount.
Concepts: `if / else if / else`

| Input | Output |
|---|---|
| 6000 | 20%, 1200, 4800 |
| 1500 | 0%, 0, 1500 |

## Question 3 – Leap Year
Divisible by 400 → leap; else divisible by 100 → not leap; else divisible by 4 → leap.
Concepts: `if / else if`, modulus `%`

| Input | Output |
|---|---|
| 2024 | Leap Year |
| 1900 | NOT a Leap Year |

## Question 4 – Simple Calculator
Reads two `double` numbers and an operator (`+ - * /`) and prints the result. Handles division by zero and invalid operators.
Concepts: `switch`, `double.TryParse`

| Input | Output |
|---|---|
| 10, 5, + | 10 + 5 = 15 |
| 8, 0, / | Error: Division by zero |

## How to Run
```bash
dotnet new console -n Demo
# replace Program.cs with the QuestionN.cs file
dotnet run
```
