// 8. Write a C# Sharp program that takes a number as input and print its multiplication table.

Console.WriteLine("Input number : ");
var a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Multiplication table of 5 is");
for (int b = 1; b <= 10; b++)
{
    Console.WriteLine($"{a} X {b} = {a} * {b}");
}