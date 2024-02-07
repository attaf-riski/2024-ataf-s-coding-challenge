// https://www.codewars.com/kata/514b92a657cdc65150000006/train/csharp

using System;

public static class Kata
{

    public static void Main(string[] args)
    {
        Console.WriteLine(Narcissistic(153));

    }

    public static bool Narcissistic(int value)
    {
        int sum = 0;
        int fixvalue = value;
        int square = value.ToString().Length;
        for(int i=0;i<square;i++)
        {
            sum += (int)Math.Pow(value % 10,square);
            value /= 10;
        }
        return sum == fixvalue;
    }
}
