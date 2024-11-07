class Program
{
    static void Main()
    {
        int sum = 0;
        int number;

        // while Cycle for adding positive numbers
        while (true)
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                break; // Stopping the loop if the number is negative
            }

            sum += number; // Adding the number to the total sum
        }

        // Printing the sum
        Console.WriteLine($"Sum: {sum}");
    }
}

