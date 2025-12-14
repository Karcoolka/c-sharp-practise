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
    }
}