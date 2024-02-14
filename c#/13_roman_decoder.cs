// // https://www.codewars.com/kata/585d7d5adb20cf33cb000235/train/csharp

// using System;
// using System.Collections.Generic;
// using System.Linq;

// public static class Kata
// {

//     public static void Main(string[] args)
//     {
//         Console.WriteLine(RomanDecode("IV")); // 1
//     }



//     public static int RomanDecode(string roman)
//     {
//         Dictionary<char, int> romanNumerals = new Dictionary<char, int>
//         {
//             {'I', 1},
//             {'V', 5},
//             {'X', 10},
//             {'L', 50},
//             {'C', 100},
//             {'D', 500},
//             {'M', 1000}
//         };

//         int result = 0;
//         int previous = 0;

//         foreach (char numeral in roman.Reverse())
//         {
//             int value = romanNumerals[numeral];

//             if (value < previous)
//             {
//                 result -= value;
//             }
//             else
//             {
//                 result += value;
//             }

//             previous = value;
//         }

//         return result;
//     }
// }
