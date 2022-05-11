// 10. Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z.

Console.WriteLine("Input for p :");
var x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input for q :");
var y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input for r :");
var z = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Out of (x+y).z = {(x + y) * z}");
Console.WriteLine($"Out of x.y + y.z = {x * y + y * z }");