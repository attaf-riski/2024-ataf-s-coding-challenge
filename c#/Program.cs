using System;

public class Kata
{

    public static void Main(string[] args)
    {
        Console.WriteLine(CreatePhoneNumber([1,2,3,4,5,6,7,8,9,0]));
    }

    // cara 1 
    // public static string CreatePhoneNumber(int[] numbers)
    // {
    //         return $"({numbers[0]}{numbers[1]}{numbers[2]}) {numbers[3]}{numbers[4]}{numbers[5]}-{numbers[6]}{numbers[7]}{numbers[8]}{numbers[9]}";
    // }

    // cara 2
    public static string CreatePhoneNumber(int[] numbers)
    {
            return string.Format("({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}", numbers[0], numbers[1], numbers[2], numbers[3], numbers[4], numbers[5], numbers[6], numbers[7], numbers[8], numbers[9]);
    }
}