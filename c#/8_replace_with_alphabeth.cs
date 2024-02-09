// // https://www.codewars.com/kata/546f922b54af40e1e90001da/train/csharp

// using System;
// using System.Collections.Generic;

// public static class Kata
// {

//     public static void Main(string[] args)
//     {
//         Console.WriteLine(AlphabetPosition("."));
//     }

//     public static string AlphabetPosition(string text)
//     {
//         text = text.ToUpper();
//         string result = "";
//         for(int i=0;i<text.Length;i++){
//             if(text[i] >= 65 && text[i] <= 90){
//                 result += (Convert.ToInt32(text[i])-64);
//                 result += " ";
//             }
//         }
//             if(result.Length == 0){
//                 return result;
//             }
//         return result[..^1];
//     }
// }
