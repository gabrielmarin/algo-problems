namespace RandomChallenges.FromAlgoExpert.TwoNumberSum;

public static class TwoNumberSumChallenge
{
    /// <summary>
    /// Find two numbers in the input array that sum up to the target sum.
    /// It needs to be 2 different numbers 
    /// Assume that at most one pair of numbers will be summing up to the targetSum
    /// </summary>
    /// <param name="inputArray"> Non-empty array of distinct integers</param>
    /// <param name="targetSum"> Desired sum between 2 numbers</param>
    /// <returns>array of int with the 2 numbers used to achieve the targetSum</returns>
    /// Example:
    ///     inputArray = [3, 5, -4, 8, 11, 1, -1, 6]
    ///     targetSum = 10
    ///     output = [-1, 11] 
    public static int[] TwoNumberSum(int[] inputArray, int targetSum)
    {
        var visitedNumbers = new HashSet<int>();
        for (var i = 0; i < inputArray.Length; i++)
        {
            if (visitedNumbers.TryGetValue(targetSum - inputArray[i], out var visitedNum))
                return new[] { visitedNum, inputArray[i] };
            
            visitedNumbers.Add(inputArray[i]);
        }

        return Array.Empty<int>();
    }
}