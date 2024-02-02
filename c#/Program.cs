
using System;

public class OddEven
{
    public static void Main(string[] args)
    {
        Console.WriteLine(evenOrOdd(2));
    }

    public static string evenOrOdd(int number)
    {
        return (number % 2 == 0) ? "Even" : "Odd";
    }
}