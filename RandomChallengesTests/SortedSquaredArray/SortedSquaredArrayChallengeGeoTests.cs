using FluentAssertions;
using RandomChallenges.SortedSquaredArray;

namespace RandomChallengesTests.SortedSquaredArray
{
    public class SortedSquaredArrayChallengeGeoTests
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3, 5, 6, 8, 9 }, new[] { 1, 4, 9, 25, 36, 64, 81 })]
        [InlineData(new[] { 1 }, new[] { 1 })]
        [InlineData(new[] { 1, 2 }, new[] { 1, 4 })]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, new[] { 1, 4, 9, 16, 25 })]
        [InlineData(new[] { 0 }, new[] { 0 })]
        [InlineData(new[] { 10 }, new[] { 100 })]
        [InlineData(new[] { -1 }, new[] { 1 })]
        [InlineData(new[] { -2, -1 }, new[] { 1, 4 })]
        [InlineData(new[] { -5, -4, -3, -2, -1 }, new[] { 1, 4, 9, 16, 25 })]
        [InlineData(new[] { -10, -5, 0, 5, 10 }, new[] { 0, 25, 25, 100, 100 })]
        [InlineData(new[] { -7, -3, 1, 9, 22, 30 }, new[] { 1, 9, 9, 49, 484, 900 })]
        [InlineData(new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 })]
        [InlineData(new[] { -1, -1, 2, 3, 3, 3, 4 }, new[] { 1, 1, 4, 9, 9, 9, 16 })]
        public void ComputeArrayTest(int[] sortedArray, int[] squaredArray)
        {
            var arrayChallengeGeo = new SortedSquaredArrayChallengeGeo(sortedArray);
            arrayChallengeGeo.ComputeArray();
            arrayChallengeGeo.SortedSquaredArray.Should().ContainInOrder(squaredArray);
        }
    }
}