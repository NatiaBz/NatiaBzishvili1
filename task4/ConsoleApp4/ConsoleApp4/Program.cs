class Program
{
    static void Main()
    {
        // Input a number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // for loop printing the multiplication table
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }
    }
}

