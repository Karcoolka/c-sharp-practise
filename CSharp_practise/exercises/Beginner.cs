namespace Exercise.exercises;

public class Beginner
{
    // Function to reverse a string
    public static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray(); 
        Array.Reverse(charArray);               
        return new string(charArray);           
    }
}