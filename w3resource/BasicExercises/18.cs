// 18. Write a C# program to check two given integers and return true if one is negative and one is positive.

Console.WriteLine("Enter 1st number : ");
var num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter 2nd number : ");
var num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine((num1 < 0 && num2 > 0) || (num1 > 0 && num2 < 0));