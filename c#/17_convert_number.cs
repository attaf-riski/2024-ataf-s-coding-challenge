// // https://www.codewars.com/kata/515bb423de843ea99400000a/solutions/csharp

// using System;
// using System.Collections.Generic;
// using System.Linq;

// public static class Kata
// {

//     public static void Main(string[] args)
//     {
//         long[] digits = Digitize(0);
//         foreach (long digit in digits)
//         {
//             Console.WriteLine(digit);
//         }
//     }

//     public static long[] Digitize(long n)
//     {
//         // edge case 0
//         if(n == 0){
//             long[] result = {0};
//             return result;
//         }

//         // normal case
//         List<long> digits = new List<long>();
//         while (n > 0)
//         {
//             digits.Add(n % 10);
//             n /= 10;
//         }
//         return digits.ToArray();
//     }
// }
