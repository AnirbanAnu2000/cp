// 19. Write a C# program to compute the sum of two given integers, if two values are equal then return the triple of their sum.

Console.WriteLine("Enter 1st number : ");
var num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter 2nd number : ");
var num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine((num1 == num2) ? (num1 + num2) * 3 : (num1 + num2));