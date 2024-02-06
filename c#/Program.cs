// https://www.codewars.com/kata/514b92a657cdc65150000006/train/csharp

using System;

public static class Kata
{

    public static void Main(string[] args)
    {
        Console.WriteLine(ThreeOrFive(10));
        Console.WriteLine(ThreeOrFive(20));
        Console.WriteLine(ThreeOrFive(200));
        Console.WriteLine(ThreeOrFive(0));
    }

    public static int ThreeOrFive(int number)
    {
        if (number <= 0)
        {
            return 0;
        }

        int buffer = 0;
        for(int i = 3;i<number;i++){
            if(i % 3 == 0 || i % 5 == 0){
                buffer += i;
            }
        }
        return buffer;
    }
}
