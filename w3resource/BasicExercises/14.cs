// 14. Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.

Console.WriteLine("Enter temperature in degree celsius");
var tempDegreesCelsius = Convert.ToInt32(Console.ReadLine());

var tempKelvin = tempDegreesCelsius + 273.15;
var tempFahrenheit = (tempDegreesCelsius * 9/5) +32;

Console.WriteLine($"For {tempDegreesCelsius} degree Celsius temperature in kelvin is {tempKelvin} degree.");
Console.WriteLine($"For {tempDegreesCelsius} degree Celsius temperature in fahrenheit is {tempFahrenheit} degree.");