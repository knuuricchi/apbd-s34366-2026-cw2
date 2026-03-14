namespace Console_Application;

public class StatisticsHelper
{
    public static int CalculateMax(int[] values)
    {
        return values.Max();
    }

    public static double CalculateAverage(int[] values)
    {
        return values.Average();
    }

    public static int GetMax(int[] values)
    {
        int maxValue = int.MinValue;
        foreach (int value in values)
        {
            if (value > maxValue)
            {
                maxValue = value;
            }
        }
        return maxValue;
    }
}