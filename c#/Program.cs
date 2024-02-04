using System;
using System.Collections.Generic;

public class Kata
{

    public static void Main(string[] args)
    {
        Console.WriteLine(IsPangram("The quick brown fox jumps over the lazy dog."));
    }
    // O(n) solution
    // public static bool IsPangram(string str)
    // {
    //     str = str.ToLower();
    //     for (char c = 'a'; c <= 'z'; c++)
    //     {
    //         if (str.IndexOf(c) == -1)
    //         {
    //             return false;
    //         }
    //     }
    //     return true;
    // }
}