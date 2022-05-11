// 6. Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user.

Console.WriteLine("Enter 1st number : ");
var num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter 2nd number : ");
var num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter 3rd number : ");
var num3 = Convert.ToInt32(Console.ReadLine());

var num4 = num1 * num2 * num3;

Console.WriteLine($"{num1} x {num2} x {num3} is = {num4}");