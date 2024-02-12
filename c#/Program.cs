// https://www.codewars.com/kata/54b42f9314d9229fd6000d9c/train/csharp

using System;
using System.Collections.Generic;

public static class Kata
{

    public static void Main(string[] args)
    {
        Console.WriteLine(sqInRect(5, 3));
    }

    public static List<int> sqInRect(int lng, int wdth)
    {
        List<int> result = new List<int>();
        if (lng == wdth)
        {
            return null;
        }
        while (lng > 0 && wdth > 0)
        {
            if (lng > wdth)
            {
                result.Add(wdth);
                lng -= wdth;
            }
            else
            {
                result.Add(lng);
                wdth -= lng;
            }
        }
        return result;
    }
}
