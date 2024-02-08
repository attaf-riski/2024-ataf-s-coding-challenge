// // https://www.codewars.com/kata/514b92a657cdc65150000006/train/csharp

// using System;
// using System.Collections.Generic;

// public static class Kata
// {

//     public static void Main(string[] args)
//     {
//         Console.WriteLine(TwoSum([1,5,3],4).ToString());
//     }

//     public static int[] TwoSum(int[] numbers, int target)
//     {
//         Dictionary<int, int> numIndices = new Dictionary<int, int>();

//         for (int i = 0; i < numbers.Length; i++)
//         {
//             int complement = target - numbers[i];

//             if(numIndices.ContainsKey(complement)){
//                 return new int[]{numIndices[complement],i};
//             }

//             if(!numIndices.ContainsKey(numbers[i])){
//                 numIndices.Add(numbers[i],i);
//             }
//         }

//         return new int[]{0,0};
//     }
// }
