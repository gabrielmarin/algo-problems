using FluentAssertions;
using RandomChallenges.SortedSquaredArray;

namespace RandomChallengesTests.SortedSquaredArray;

public class SortedSquaredArrayMarinTests
{
    [Fact]
    public void ShouldReturnBasicSquaredArray()
    {
        var inputArray = new[] { 1, 2, 3, 5, 6, 8, 9 };
        var expectedResult = new[] { 1, 4, 9, 25, 36, 64, 81 };
        var result = SortedSquaredArrayMarin.SortedSquaredArray(inputArray);
        result.Should().BeEquivalentTo(expectedResult);
    }
}