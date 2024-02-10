// // https://www.codewars.com/kata/54b42f9314d9229fd6000d9c/train/csharp

// using System;
// using System.Collections.Generic;

// public static class Kata
// {

//     public static void Main(string[] args)
//     {
//         Console.WriteLine(DuplicateEncode("recede"));
//     }

//    public static string DuplicateEncode(string word)
//   {
//     Dictionary<char, int> dict = new Dictionary<char, int>();
//     word = word.ToLower();
//     foreach (char c in word)
//     {
//       if (dict.ContainsKey(c))
//       {
//         dict[c]++;
//       }
//       else
//       {
//         dict.Add(c, 1);
//       }
//     }
//     foreach (char c in word)
//     {
//       if (dict[c] > 1)
//       {
//         word = word.Replace(c, ')');
//       }
//       else
//       {
//         word = word.Replace(c, '(');
//       }
//     }
//     return word;
//   }
// }
