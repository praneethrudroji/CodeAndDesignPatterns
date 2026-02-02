using System;

namespace Programming;

public class GenerateSubstrings
{
    private static void GenerateSubsequencesHelper(string input, int index, string current, List<string> substrings)
    {
        if (index == input.Length)
        {
            if (current.Length > 0)
            {
                substrings.Add(current);
            }
            return;
        }

        // Include the current character
        GenerateSubsequencesHelper(input, index + 1, current + input[index], substrings);

        // Exclude the current character
        GenerateSubsequencesHelper(input, index + 1, current, substrings);
    }
    private static void GenerateSubstringsHelper(string input, int start, List<string> substrings)
    {
        if (start >= input.Length)
            return;

        for (int end = start + 1; end <= input.Length; end++)
        {
            substrings.Add(input.Substring(start, end - start));
        }

        GenerateSubstringsHelper(input, start + 1, substrings);
    }

    public static List<string> GetAllSubstrings(string input)
    {
        List<string> substrings = [];

         GenerateSubstringsHelper(input, 0, substrings);

        return substrings;
    }
}
