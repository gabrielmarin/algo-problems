using FluentAssertions;
using RandomChallenges.ValidateSubsequence;

namespace RandomChallengesTests.ValidateSubsequence;

public class ValidateSubsequenceTests
{
    public static IEnumerable<object[]> TestsInputParams()
    {
        yield return new object[] {new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 }, new List<int>{ 1,6,-1,10 }, true};
        yield return new object[] {new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 }, new List<int> { 25 }, true};
        yield return new object[] {new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 }, new List<int> { 5, 1, 22, 25, 6, -1, 8, 10, 12 }, false};
    }

    [Theory]
    [MemberData(nameof(TestsInputParams))]
    public void ShouldRunSmoothly(List<int> array, List<int> sequence, bool expectedOutput)
    {
        var result =ValidateSubsequenceChallenge.IsValidSubsequence(array, sequence);
        result.Should().Be(expectedOutput);
    }
}