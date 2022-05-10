// 17. Write a C# program to create a new string from a given string (length 1 or more ) with the first character added at the front and back.

Console.WriteLine("Enter a string value : ");
var inputString = Console.ReadLine();

var firstString = Convert.ToString(inputString[0]);

var outputResult = inputString.Length >= 1 ? String.Concat(firstString, inputString, firstString) : inputString;
Console.WriteLine(outputResult);