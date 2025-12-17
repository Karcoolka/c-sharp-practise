namespace Exercise.exercises;

public class Beginner
{
    // git init
    // git add .
    // git commit -m "Initial commit"
    // git branch -M main
    // git remote add origin https://github.com/Karcoolka/c-sharp-practise.git
    // git push -u origin main  
    
    // Git will ask for GitHub username and personal access token (instead of your password)
    // To get a token: https://github.com/settings/tokens
    // → Generate new token → select repo permissions → copy it.
    // Paste the token when prompted for a password.
    
    
    
    // Function to reverse a string
    public static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray(); 
        Array.Reverse(charArray);               
        return new string(charArray);           
    }

    // Check Even or Odd
    public static string CheckEvenOdd(int number)
    {
        return number % 2 == 0 ? "Even" : "Odd";
    }
    
    //Sum of all numbers in an integer array.
    public static int SumArray(int[] numbers)
    {
        return numbers.Sum();
    }
    
    // Counts how many times a given number appears in an array.
    public static int CountOccurrences(int[] numbers, int number)
    {
        return numbers.Count(n => n == number);
    }
    
    
    // Counts the number of vowels in a string.
    public static int CountVowels(string str)
    {
        return str
            .ToLower()
            .Count(c => "aeiou".Contains(c));
    }
    
}