using System;

class Program
{
    static void Main()
    {
        // First task: Array for student names
        string[] students = new string[3];

        // Getting student names
        for (int i = 0; i < students.Length; i++)
        {
            Console.Write("Enter student name: ");
            students[i] = Console.ReadLine();
        }

        // Printing the list of student names
        Console.WriteLine("\nList of students:");
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }

        // Second task: 2D array for student grades
        int[,] grades = new int[3, 2]; // 3 students, each with 2 grades

        // Getting grades for each student
        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine($"\nEnter grades for {students[i]}:");

            // Enter grade for the first subject
            Console.Write("Enter grade for subject 1: ");
            grades[i, 0] = int.Parse(Console.ReadLine());

            // Enter grade for the second subject
            Console.Write("Enter grade for subject 2: ");
            grades[i, 1] = int.Parse(Console.ReadLine());
        }

        // Printing student names and their grades
        Console.WriteLine("\nStudent grades:");
        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine($"{students[i]}: {grades[i, 0]} (Subject 1), {grades[i, 1]} (Subject 2)");
        }
    }
}

