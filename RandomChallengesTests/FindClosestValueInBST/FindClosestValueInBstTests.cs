using FluentAssertions;
using RandomChallenges.FromAlgoExpert.FindClosestValueInBST;

namespace RandomChallengesTests.FindClosestValueInBST;

public class FindClosestValueInBstTests
{
    [Fact]
    public void ShouldRunSmoothly()
    {
        var binarySearchTree = new FindClosestValueChallenge.BST(10)
        {
            left = new (5)
            {
                left = new (2)
                {
                    left = new(1)
                },
                right = new (5) 
            },
            right = new (15)
            {
                left = new(13)
                {
                    right = new (14)
                },
                right = new(22)
            }
        };
        var target = 12;

        var result = FindClosestValueChallenge.FindClosestValueInBst(binarySearchTree, target);
        result.Should().Be(13);
    }
}