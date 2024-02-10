// // https://www.codewars.com/kata/54b42f9314d9229fd6000d9c/train/csharp

// using System;
// using System.Collections.Generic;

// public static class Kata
// {

//     public static void Main(string[] args)
//     {
//         Console.WriteLine(DuplicateEncode("...It Should encode XXX"));
//     }

//     public static string DuplicateEncode(string word)
//     {
//         Dictionary<char, int> letterCount = new Dictionary<char, int>();
//         var letters = word.ToLower().ToCharArray();

//         foreach (char letter in letters)
//         {
//             if (letterCount.ContainsKey(letter))
//                 letterCount[letter]++;
//             else
//                 letterCount.Add(letter, 1);
//         }

//         string result = "";
//         foreach (char letter in letters)
//         {
//             if (letterCount[letter] > 1)
//                 result += ")";
//             else
//                 result += "(";
//         }

//         return result;
//     }
// }
