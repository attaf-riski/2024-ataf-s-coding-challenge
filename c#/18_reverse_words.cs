// using System;

// public static class Kata
// {
//   public static string ReverseWords(string str)
//   {
//     string[] words = str.Split(' ');
//     for (int i = 0; i < words.Length; i++)
//     {
//       char[] word = words[i].ToCharArray();
//       Array.Reverse(word);
//       words[i] = new string(word);
//     }
//     return string.Join(" ", words);
//   }
// }