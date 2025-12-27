namespace Exercise.exercises;

public class Intermediate
{
    // Finds all pairs of numbers in an array that sum to a given target
    // Input:  nums = [2, 7, 11, 15, -2, 9, 1, 8]
    // Target: 9
    //
    // Output:
    // (2, 7)
    // (-2, 11)
    // (1, 8)


    public static List<(int, int)> TwoSumPairs(int[] nums, int target)
    {
        List<(int, int)> result = new List<(int, int)>();
        HashSet<int> seen = new HashSet<int>();
        HashSet<string> usedPairs = new HashSet<string>();

        foreach (int num in nums)
        {
            int complement = target - num;

            if (seen.Contains(complement))
            {
                int a = Math.Min(num, complement);
                int b = Math.Max(num, complement);

                string key = $"{a},{b}";

                if (!usedPairs.Contains(key))
                {
                    result.Add((a, b));
                    usedPairs.Add(key);
                }
            }

            seen.Add(num);
        }

        return result;
    }
}