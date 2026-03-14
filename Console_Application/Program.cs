// See https://aka.ms/new-console-template for more information
using Console_Application;

int[] values = { 1, 2, 3, 4, 5 };

int maxValue = StatisticsHelper.CalculateMax(values);
int averageValue = (int)StatisticsHelper.CalculateAverage(values);
int minValue = StatisticsHelper.GetMax(values);

Console.WriteLine($"The maximum value is: {maxValue}");
Console.WriteLine($"Average of values is: {averageValue} ");