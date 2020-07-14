using System;
namespace PalindromeExercise
{
    public class WordSmith
    {
        public WordSmith()
        {
        }
        public bool IsAPalindrome(string str)
        {
            string reversedWord = ReverseString(str);
            if(reversedWord.ToLower() != str.ToLower())
            {
                return false;
            }
            return true;
        }
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
