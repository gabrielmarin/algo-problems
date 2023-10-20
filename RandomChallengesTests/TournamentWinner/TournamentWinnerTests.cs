using FluentAssertions;
using RandomChallenges.TournamentWinner;

namespace RandomChallengesTests.TournamentWinner;

public class TournamentWinnerTests
{
    public static IEnumerable<object[]> TestInputParams()
    {
        yield return new object[]
        {
            new List<List<string>> { new() { "HTML", "C#" }, new() { "C#", "Python" }, new() { "Python", "HTML" } },
            new List<int> { 0, 0, 1 },
            "Python"
        };
        
        yield return new object[]
        {
            new List<List<string>>
            {
                new() {"AlgoMasters", "FrontPage Freebirds"},
                new() {"Runtime Terror", "Static Startup"},
                new() {"WeC#", "Hypertext Assassins"},
                new() {"AlgoMasters", "WeC#"},
                new() {"Static Startup", "Hypertext Assassins"},
                new() {"Runtime Terror", "FrontPage Freebirds"},
                new() {"AlgoMasters", "Runtime Terror"},
                new() {"Hypertext Assassins", "FrontPage Freebirds"},
                new() {"Static Startup", "WeC#"},
                new() {"AlgoMasters", "Static Startup"},
                new() {"FrontPage Freebirds", "WeC#"},
                new() {"Hypertext Assassins", "Runtime Terror"},
                new() {"AlgoMasters", "Hypertext Assassins"},
                new() {"WeC#", "Runtime Terror"},
                new() {"FrontPage Freebirds", "Static Startup"}
            },
            new List<int> { 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0 },
            "AlgoMasters"
        };
    }

    [Theory]
    [MemberData(nameof(TestInputParams))]
    public void ShouldRunSmoothly(List<List<string>> competitions, List<int> results, string expectedOutput)
    {
        var result = TournamentWinnerChallenge.TournamentWinner(competitions, results);
        result.Should().Be(expectedOutput);
    }
}