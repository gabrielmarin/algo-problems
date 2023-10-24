using FluentAssertions;
using RandomChallenges.FromAlgoExpert.BranchSums;
using RandomChallenges.FromAlgoExpert.NodeDepths;

namespace RandomChallengesTests.NodeDepths;

public class NodeDepthsTests
{
    [Fact]
    public void ShouldRunSmoothly()
    {
        var binarySearchTree = new NodeDepthsChallenge.BinaryTree(1)
        {
            Left = new (2)
            {
                Left = new (4)
                {
                    Left = new (8),
                    Right = new (9)
                },
                Right = new (5)
            },
            Right = new (3)
            {
                Left = new(6),
                Right = new(7)
            }
        };

        var result = NodeDepthsChallenge.NodeDepths(binarySearchTree);
        result.Should().Be(16);
    }
}