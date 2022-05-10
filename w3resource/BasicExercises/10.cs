// 10. Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z.

Console.WriteLine("Input for p :");
var p = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input for q :");
var q = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input for r :");
var r = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Out of (p+q).r = {(p + q)*r}");
Console.WriteLine($"Out of p.q + q.r = {p*q + q*r }");