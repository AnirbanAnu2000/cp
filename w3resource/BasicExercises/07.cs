// 7. Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user.


Console.WriteLine("Enter 1st number : ");
var num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter 2nd number : ");
var num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{num1} + {num2} is = {num1 + num2}");
Console.WriteLine($"{num1} - {num2} is = {num1 - num2}");
Console.WriteLine($"{num1} x {num2} is = {num1 * num2}");
Console.WriteLine($"{num1} / {num2} is = {num1 / num2}");