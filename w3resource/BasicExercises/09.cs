// 9. Write a C# Sharp program that takes four numbers as input to calculate and print the average.

Console.WriteLine("Input number1 : ");
var input1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number2 : ");
var input2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number3 : ");
var input3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number4 : ");
var input4 = Convert.ToInt32(Console.ReadLine());

var result = (input1 + input2 + input3 + input4) / 4;
Console.WriteLine($"The average of {input1}, {input2}, {input3} and {input4} is = {result}");