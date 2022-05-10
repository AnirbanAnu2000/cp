// 20. Write a C# program to get the absolute value of the difference between two given numbers. Return double the absolute value of the difference if the first number is greater than second number.

var x = Convert.ToInt32(Console.ReadLine());
var y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine((x > y) ? (x - y) * 2 : Math.Abs(x - y));