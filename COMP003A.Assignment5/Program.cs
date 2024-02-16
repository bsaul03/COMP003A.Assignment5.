using System;

/// <summary>
/// Author: Saul Barajas
/// Course: COMP003A-L01
/// Purpose: Assignment 5
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        PrintSeparator("Triangle");

        Console.Write("Enter a single character: ");
        char inputCharacter = Convert.ToChar(Console.ReadLine());

        Console.Write("Enter a positive whole number: ");
        int size = Convert.ToInt32(Console.ReadLine());

        IsoscelesTriangleBuilder(inputCharacter, size);

        PrintSeparator("Favorite Characters");

        CharacterInfo("Spider-Man", 1962);
        CharacterInfo("Batman", 1939);
        CharacterInfo("Rick", 1943);
        CharacterInfo("Stewie", 1998);
        CharacterInfo("Iron Man", 1963);
    }

    /// <summary>
    /// Outputs 50 asterisks to the console.
    /// </summary>
    static void PrintSeparator()
    {
        Console.WriteLine(new string('*', 50));
    }

    /// <summary>
    /// Outputs a specified string as a separator.
    /// </summary>
    /// <param name="separator">The string to be used as a separator.</param>
    static void PrintSeparator(string separator)
    {
        Console.WriteLine(separator);
    }

    /// <summary>
    /// Builds an  triangle using the provided character and size.
    /// </summary>
    static void IsoscelesTriangleBuilder(char inputCharacter, int size)
    {
        for (int i = 1; i <= size; i++)
        {
            Console.WriteLine(new string(inputCharacter, i));
        }

        for (int i = size - 1; i >= 1; i--)
        {
            Console.WriteLine(new string(inputCharacter, i));
        }
    }

    /// <summary>
    /// Calculates the age based on the provided birth year.
    /// </summary>
    static int AgeCalculator(int year)
    {
        int currentYear = DateTime.Now.Year;
        return currentYear - year;
    }

    /// <summary>
    /// Outputs the name and calculated age of a character.
    /// </summary>
    static void CharacterInfo(string name, int birthYear)
    {
        int age = AgeCalculator(birthYear);
        Console.WriteLine($"{name} is {age} years old.");
    }
}
