// 16. Write a C# program to create a new string from a given string where the first and last characters will change their positions.

Console.WriteLine("Enter a string value : ");
var inputString = Console.ReadLine();

var firstString = Convert.ToString(inputString[0]);
var lastString = Convert.ToString(inputString[inputString.Length - 1]);

var middleString = inputString.Substring(1, inputString.Length-2);

Console.WriteLine($"\nOriginal string before interchanging first & last character is {inputString}");
Console.WriteLine($"\nNew string interchange first & last character of {inputString} is {String.Concat(lastString, middleString, firstString)}");