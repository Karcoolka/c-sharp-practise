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
    
    //Checks whether a string is a palindrome
    public static bool IsPalindrome(string text)
    {
        string cleaned = text.ToLower().Replace(" ", "");

        int left = 0;
        int right = cleaned.Length - 1;

        while (left < right)
        {
            if (cleaned[left] != cleaned[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
    
    //Finds the first non-repeating character in a string
    public static char FirstNonRepeatingChar(string text)
    {
        if (string.IsNullOrEmpty(text))
            return '\0';

        Dictionary<char, int> counts = new Dictionary<char, int>();

        foreach (char c in text.ToLower())
        {
            if (counts.ContainsKey(c))
                counts[c]++;
            else
                counts[c] = 1;
        }

        foreach (char c in text.ToLower())
        {
            if (counts[c] == 1)
                return c;
        }

        return '\0';
    }
    
    // Check whether two strings are anagrams
    public static bool IsAnagram(string str1, string str2)
    {
        return string.Concat(str1.OrderBy(c => c)) == string.Concat(str2.OrderBy(c => c));
    }   
    
    public static bool AreAnagrams(string s1, string s2)
    {
        // 1. Normalize strings (lowercase + remove spaces)
        s1 = s1.ToLower().Replace(" ", "");
        s2 = s2.ToLower().Replace(" ", "");

        // 2. If lengths differ, they cannot be anagrams
        if (s1.Length != s2.Length)
            return false;

        // 3. Count characters in first string
        Dictionary<char, int> counts = new Dictionary<char, int>();

        foreach (char c in s1)
        {
            if (counts.ContainsKey(c))
                counts[c]++;
            else
                counts[c] = 1;
        }

        // 4. Subtract counts using second string
        foreach (char c in s2)
        {
            if (!counts.ContainsKey(c))
                return false;

            counts[c]--;

            if (counts[c] < 0)
                return false;
        }

        return true;
    }
    
    // Finds the longest substring without repeating characters
    public static int LongestUniqueSubstring(string text)
    {
        if (string.IsNullOrEmpty(text))
            return 0;

        HashSet<char> seen = new HashSet<char>();

        int left = 0;
        int maxLength = 0;

        for (int right = 0; right < text.Length; right++)
        {
            // If duplicate found, move left pointer
            while (seen.Contains(text[right]))
            {
                seen.Remove(text[left]);
                left++;
            }

            seen.Add(text[right]);
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
    
}