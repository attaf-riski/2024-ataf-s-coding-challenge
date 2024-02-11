// https://www.codewars.com/kata/54b42f9314d9229fd6000d9c/train/csharp

using System;
using System.Collections.Generic;

public static class Kata
{

    public static void Main(string[] args)
    {
        Console.WriteLine(IsPrime(5));
    }

    public static bool IsPrime(int n)
    {
        if (n < 2) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;
        for (int i = 3; i <= Math.Sqrt(n); i += 2)
        {
            if (n % i == 0) return false;
        }
        return true;   
    }
}
