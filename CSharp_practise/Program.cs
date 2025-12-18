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
    }
}