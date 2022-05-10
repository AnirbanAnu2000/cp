// 18. Write a C# program to check two given integers and return true if one is negative and one is positive.

var x = -5;
var y = 5;

Console.WriteLine((x < 0 && y > 0) || (x > 0 && y < 0));