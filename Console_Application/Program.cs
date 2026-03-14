// See https://aka.ms/new-console-template for more information
using Console_Application;

Console.WriteLine("Hello, World!");
int[] values = { 1, 2, 3, 4, 5 };
int maxValue = StatisticsHelper.CalculateMax(values);
Console.WriteLine($"The maximum value is: {maxValue}");