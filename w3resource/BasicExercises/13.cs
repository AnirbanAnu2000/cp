// 13. Write a C# program that takes a number as input and then displays a rectangle of 3 columns wide and 5 rows tall using that digit.

Console.WriteLine("Enter number : ");
var number = Convert.ToInt32(Console.ReadLine());

Console.Write($"{number}{number}{number}\n{number} {number}\n{number} {number}\n{number} {number}\n{number}{number}{number}");