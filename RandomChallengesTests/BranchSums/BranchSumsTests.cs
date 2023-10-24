using FluentAssertions;
using RandomChallenges.FromAlgoExpert.BranchSums;

namespace RandomChallengesTests.BranchSums;

public class BranchSumsTests
{
    [Fact]
    public void ShouldRunSmoothly()
    {
        var binarySearchTree = new BranchSumsChallenge.BinaryTree(1)
        {
            Left = new (2)
            {
                Left = new (4)
                {
                    Left = new (8),
                    Right = new (9)
                },
                Right = new (5)
                {
                    Left = new (10)
                }
            },
            Right = new (3)
            {
                Left = new(6),
                Right = new(7)
            }
        };
        var expectedOutput = new List<int> { 15, 16, 18, 10, 11 };

        var result = BranchSumsChallenge.BranchSums(binarySearchTree);
        result.Should().Equal(expectedOutput);
    }
}