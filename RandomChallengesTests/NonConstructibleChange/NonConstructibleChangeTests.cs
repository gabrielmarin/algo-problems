using FluentAssertions;
using RandomChallenges.NonConstructibleChange;

namespace RandomChallengesTests.NonConstructibleChange;

public class NonConstructibleChangeTests
{
    [Theory]
    [InlineData(new int[] { }, 1)]
    [InlineData(new[] { 2 }, 1)]
    [InlineData(new[] { 1, 2 }, 4)]
    [InlineData(new[] { 5, 7, 1, 1, 2, 3, 22 }, 20)]
    [InlineData(new[] { 1, 1, 1, 1, 1 }, 6)]
    public void ShouldRunSmoothly(int[] coins, int expectedResult)
    {
        var result = NonConstructibleChangeChallenge.NonConstructibleChange(coins);
        result.Should().Be(expectedResult);
    }
}