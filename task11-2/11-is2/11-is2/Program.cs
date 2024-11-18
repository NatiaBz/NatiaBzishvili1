public static class MathHelper
{
    //+
    public static int Add(int a, int b)
    {
        return a + b;
    }

    // -
    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    // *
    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    // /, 0-ze gayofa ar SeiZleba
    public static double Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return (double)a / b;
    }
}

public class Program
{
    public static void Main()
    {
        int a = 10;
        int b = 5;

        // MathHelper 
        Console.WriteLine($"Add: {MathHelper.Add(a, b)}");           // 10 + 5 = 15
        Console.WriteLine($"Subtract: {MathHelper.Subtract(a, b)}"); // 10 - 5 = 5
        Console.WriteLine($"Multiply: {MathHelper.Multiply(a, b)}"); // 10 * 5 = 50
        try
        {
            Console.WriteLine($"Divide: {MathHelper.Divide(a, b)}"); // 10 / 5 = 2
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message); // Tu 0-ze gaiyo
        }
    }
}
