using FluentAssertions;
using RandomChallenges.SortedSquaredArray;

namespace RandomChallengesTests.SortedSquaredArray;

public class SortedSquaredArrayMarinTests
{
    public static IEnumerable<object[]> TestParameters()
    {
        yield return new object[] { new[] { 1, 2, 3, 5, 6, 8, 9 }, new[] { 1, 4, 9, 25, 36, 64, 81 } };
        yield return new object[] { new[] { 1 }, new[] { 1 } };
        yield return new object[] { new[] { 1, 2 }, new[] { 1, 4 } };
        yield return new object[] { new[] { 1, 2, 3, 4, 5 }, new[] { 1, 4, 9, 16, 25 } };
        yield return new object[] { new[] { 0 }, new[] { 0 } };
        yield return new object[] { new[] { 10 }, new[] { 100 } };
        yield return new object[] { new[] { -1 }, new[] { 1 } };
        yield return new object[] { new[] { -2, -1 }, new[] { 1, 4 } };
        yield return new object[] { new[] { -5, -4, -3, -2, -1 }, new[] { 1, 4, 9, 16, 25 } };
        yield return new object[] { new[] { -10, -5, 0, 5, 10 }, new[] { 0, 25, 25, 100, 100 } };
        yield return new object[] { new[] { -7, -3, 1, 9, 22, 30 }, new[] { 1, 9, 49, 81, 484, 900 } };
        yield return new object[] { new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } };
        yield return new object[] { new[] { -1, -1, 2, 3, 3, 3, 4 }, new[] { 1, 1, 4, 9, 9, 9, 16 } };
    }

    [Theory]
    [MemberData(nameof(TestParameters))]
    public void ShouldReturnOrderedSquaredArray(int[] inputArray, int[] expectedResultArray)
    {
        var result = SortedSquaredArrayMarin.SortedSquaredArrayEfficientWay(inputArray);
        result.Should().ContainInOrder(expectedResultArray);
    }
}