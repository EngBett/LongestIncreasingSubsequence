using System;

namespace LongestIncreasingSubsequence
{
    
    public class Solution {
        public static int LongestCommonSubsequence(string text1, string text2) {
            var store = new int[text1.Length+1,text2.Length+1];

            for (int i = store.GetLength(0)-1; i >=0; i--)
            {
                for (int j = store.GetLength(1)-1; j >=0; j--)
                {
                    if(i==store.GetLength(0)-1||j==store.GetLength(1)-1) continue;

                    if (text1[i] == text2[j])
                    {
                        store[i, j] = 1 + store[i + 1, j + 1];
                    }
                    else
                    {
                        store[i, j] = Math.Max(store[i + 1, j], store[i, j + 1]);
                    }
                }
            }
            
            return store[0,0];
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var text1 = "abcde";
            var text2 = "ace";
            
            Console.WriteLine($"Longest ===> {Solution.LongestCommonSubsequence(text1,text2)}");
        }
    }
}