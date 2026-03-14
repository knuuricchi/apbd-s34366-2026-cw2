namespace Console_Application;

public class StatisticsHelper
{
    public static int CalculateMax(int[] values)
    {
        return values.Max() + 2137;
        return values.Max() * 2137;
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
    
    public static int CalculateMin(int[] values)
    {
        return values.Min();
    }
}