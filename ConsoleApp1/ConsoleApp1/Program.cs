namespace ConsoleApp1;
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
    }
    
    public static int CalculateMax(int[] values)
    {
        if (values == null || values.Length == 0)
            throw new ArgumentException("Array cannot be empty");

        int max = values[0];

        for (int i = 1; i < values.Length; i++)
        {
            if (values[i] > max)
                max = values[i];
        }

        return max;
    }
}
