using System;

class Program
{
    // მეთოდი, რომელიც დაითვლის რიცხვის ციფრების ჯამს მოცემულ ინდექსზე
    static int SumOfDigitsAtIndex(int[] array, int index)
    {
        // თუ ინდექსი არ არის მასივის შიგნით, დავაბრუნოთ -1
        if (index < 0 || index >= array.Length)
        {
            Console.WriteLine("არასწორი ინდექსია.");
            return -1;  // დაბრუნება -1-ისთვის, რომ დავინახოთ ინდექსი არასწორია
        }

        // იღებთ მასივიდან რიცხვს მოცემულ ინდექსზე
        int number = array[index];

        // ცვლადი ციფრების ჯამის შესანახად
        int sum = 0;

        // ციფრების ჯამის გამოთვლა
        while (number > 0)
        {
            sum += number % 10;  // რიცხვის ბოლო ციფრის დამატება ჯამში
            number /= 10;  // ბოლო ციფრის წაშლა
        }

        return sum;  // დაბრუნება ციფრების ჯამის
    }

    static void Main()
    {
        // მომხმარებელს ვთხოვთ, რომ შეიყვანოს მასივის ზომა
        Console.Write("შეიყვანეთ მასივის ელემენტების რაოდენობა: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        // მომხმარებელს ვთხოვთ, რომ შეიყვანოს თითოეული ელემენტი
        for (int i = 0; i < n; i++)
        {
            Console.Write($"შეიყვანეთ ელემენტი {i}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        // მომხმარებელს ვთხოვთ, რომ შეიყვანოს ინდექსი
        Console.Write("შეიყვანეთ ინდექსი, რომელსაც დავუმოწმებთ: "
