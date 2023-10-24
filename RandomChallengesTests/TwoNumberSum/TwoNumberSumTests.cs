using FluentAssertions;
using RandomChallenges.FromAlgoExpert.TwoNumberSum;

namespace RandomChallengesTests.TwoNumberSum;

public class TwoNumberSumTests
{
    public static IEnumerable<object[]> TestInputParams()
    {
        yield return new object[] { new[] { 3, 5, -4, 8, 11, 1, -1, 6 }, 10, new[] { 11, -1 } };
        yield return new object[] { new[] { 4, 6 }, 10, new[] { 4, 6 } };
        yield return new object[] { new[] { 4, 6, 1, -3 }, 3, new[] { 6, -3} };
        yield return new object[] { new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 15 }, 18, new[] { 3, 15 } };
        yield return new object[] { new[] { 3, 5, -4, 8, 11, 1, -1, 6}, 15, Array.Empty<int>() };
    }

    [Theory]
    [MemberData(nameof(TestInputParams))]
    public void ShouldRunSmoothly(int[] inputArray, int targetSum, int[] expectedOutput)
    {
        var result = TwoNumberSumChallenge.TwoNumberSum(inputArray, targetSum);
        result.Should().BeEquivalentTo(expectedOutput);
    }
}