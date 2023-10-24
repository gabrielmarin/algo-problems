using FluentAssertions;
using RandomChallenges;
using RandomChallenges.FromCompanies.MindBodyChallenge;

namespace RandomChallengesTests.MindBodyChallenge;

public class MindBodyChallengeTest
{
 
    [Theory]
    [InlineData("And now here is my secret", 15, "And now ...")]
    [InlineData("There is an animal with four legs", 15, "There is an ...")]
    [InlineData("super dog", 4, "...")]
    [InlineData("May the Force be with you", 17, "May the Force ...")]
    public void ShouldParseMessageNotification(string message, int maxLength, string expectedOutput)
    {
        var result = MindBodyChallengeClass.ParseMessageNotificationV1(message, maxLength);
        result.Should().Be(expectedOutput);

        var resultV2 = MindBodyChallengeClass.ParseMessageNotificationV2(message, maxLength);
        resultV2.Should().Be(expectedOutput);
    }
}