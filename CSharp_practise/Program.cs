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
    }
}