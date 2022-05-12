// 22. Write a C# program to check if an given integer is within 20 of 100 or 200.

Console.WriteLine("\nInput an integer:");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine((Math.Abs(x - 100) <= 20 || Math.Abs(x - 200) <= 20));