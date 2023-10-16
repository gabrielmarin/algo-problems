using RandomChallenges;
using FluentAssertions;

namespace RandomChallengesTests
{
    public class SortedSquaredArrayChallengeGeoTests
    {
        [Theory]
        [InlineData(new [] {1,2,3,5,6,8,9}, new [] {1,4,9,25,36,64,81})]
        public void ComputeArrayTest(int[] sortedArray, int[]squaredArray)
        {
            var arrayChallengeGeo = new SortedSquaredArrayChallengeGeo(sortedArray);
            arrayChallengeGeo.ComputeArray();
            arrayChallengeGeo.SortedSquaredArray.Should().BeEquivalentTo(squaredArray);
        }
    }
}