using System;
using Exercise.exercises;

class Program
{

    static void Main()
    {
        // Beginner
        
        // Function to reverse a string
        string input = "hello2";
        string reversed = Beginner.ReverseString(input); 
        Console.WriteLine(reversed);    
        
        // Check Even or Odd
        int number = 10;
        string result = Beginner.CheckEvenOdd(number); 
        Console.WriteLine(result);
        
        //Sum of all numbers in an integer array.
        int[] numbers = {1, 2, 3, 4, 5};
        int sum = Beginner.SumArray(numbers); 
        Console.WriteLine(sum);
        
        // Counts how many times a given number appears in an array.
        int[] numbers2 = {1, 2, 3, 4, 5, 2, 2, 2};
        int count = Beginner.CountOccurrences(numbers2, 2); 
        Console.WriteLine(count);
        
        // Counts the number of vowels in a string.
        string str = "Hello Wooorld!";
        int vowels = Beginner.CountVowels(str); 
        Console.WriteLine(vowels);
        
        //Checks whether a string is a palindrome
        string text = "race car";
        bool palindrome = Beginner.IsPalindrome(text); 
        Console.WriteLine(palindrome);
        
        //Finds the first non-repeating character in a string
        string text2 = "abaCaba";
        char firstNonRepeating = Beginner.FirstNonRepeatingChar(text2); 
        Console.WriteLine(firstNonRepeating);
        
        // Checks whether two strings are anagrams
        string str1 = "listen";
        string str2 = "silent";
        bool anagram = Beginner.IsAnagram(str1, str2); 
        Console.WriteLine(anagram);
        
        bool anagram2 = Beginner.AreAnagrams(str1, str2); 
        Console.WriteLine(anagram2);
        
        // Finds the longest substring without repeating characters
        string str3 = "pwwkew";
        string str4 = "aabccbb";
        string str5 = "abcabc";
        int longest = Beginner.LongestUniqueSubstring(str3); 
        Console.WriteLine(longest);
        
        // Returns the length of the longest consecutive sequence
        int[] nums = {100, 4, 200, 1, 3, 2};
        int longestConsecutive = Beginner.LongestConsecutive(nums); 
        Console.WriteLine(longestConsecutive);  
        
        // Finds all pairs of numbers in an array that sum to a given target
        int[] nums2 = {2, 7, 11, 15};
        int target = 9;
        List<(int, int)> pairs = Beginner.TwoSumPairs(nums2, target); 
        foreach (var pair in pairs)
        {
            Console.WriteLine($"({pair.Item1}, {pair.Item2})");
        }
    }
}