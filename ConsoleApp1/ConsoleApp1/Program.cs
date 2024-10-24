using System;

namespace MyProfile
{
    class Program
    {
        static void Main(string[] args)
        {
            // ასაკი
            int age = 39;
            // სიმაღლე
            float height = 1.72f; // მეტრებში
            // წონა
            float weight = 70f; // კილოგრამში
            // სახელი
            string name = "NATIA";
            // დასაქმების სტატუსი
            bool isemployed = true;
            // საკონტაქტო ინფორმაცია
            string email = "nbzishvili1@gmail.com";
            string mobile = "598112055";

            // ბეჭდვა
            Console.WriteLine("my infomation:");
            Console.WriteLine($"name: {name}");
            Console.WriteLine($"age: {age} Year");
            Console.WriteLine($"height: {height} m");
            Console.WriteLine($"weight: {weight} kg");
            Console.WriteLine($"email: {email}");
            Console.WriteLine($"mobile: {mobile}");
            Console.WriteLine($"isemployed:{isemployed}");

            // პროგრამის დასრულება
            Console.ReadLine();
        }
    }
}


