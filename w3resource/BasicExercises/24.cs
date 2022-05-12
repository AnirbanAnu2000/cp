// 24. Write a C# program to find the longest word in a string.

//string line = "CPU stands for Central Processing Unit or Microprocessor.";
Console.WriteLine("Enter a sentence : ");
var sentence = Console.ReadLine();
var words = sentence.Split(new[] { " " }, StringSplitOptions.None);
var word = "";
var character = 0;
foreach (String singleWord in words)
{
    if (singleWord.Length > character)
    {
        word = singleWord;
        character = singleWord.Length;
    }
}

Console.WriteLine(word);