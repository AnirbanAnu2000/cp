// 2. Write a C# Sharp program to print the sum of two numbers.

Console.WriteLine("Enter 1st number : ");
var num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter 2nd number : ");
var num2 = Convert.ToInt32(Console.ReadLine());
var num3 = num1 + num2;

Console.WriteLine($"Sum of {num1} & {num2} is = {num3}");