// 12. Write a C# program to that takes a number as input and display it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it two times: Use Console. Write and then use {0}.

Console.WriteLine("Enter a number : ");
var number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("{0} {0} {0} {0}\n{0}{0}{0}{0}\n{0} {0} {0} {0}\n{0}{0}{0}{0}", number);