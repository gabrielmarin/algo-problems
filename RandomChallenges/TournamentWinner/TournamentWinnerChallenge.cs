namespace RandomChallenges.TournamentWinner;

public class TournamentWinnerChallenge
{
    /// <summary>
    /// Process all the matches and return the champion team.
    /// There's always a guaranteed winning team.
    /// There's no tie neither on the championship and on matches
    /// </summary>
    /// <param name="competitions">A list of "pairs", where the first is the home team and the second is the away team</param>
    /// <param name="results">A list of ints where 1 means home team won and 0 means away team won.</param>
    /// <returns>Championship winning team</returns>
    public static string TournamentWinner(List<List<string>> competitions, List<int> results)
    {
        var leaderboards = new Dictionary<string, int>();
        var currentChampion = (Team:"", Points:0);
        for (var i = 0; i < competitions.Count; i++)
        {
            var winnerIndex = results[i] == 0 ? 1 : 0;
            if (!leaderboards.TryAdd(competitions[i][winnerIndex], 3))
                leaderboards[competitions[i][winnerIndex]] += 3;

            if (currentChampion.Points >= leaderboards[competitions[i][winnerIndex]]) continue;
            currentChampion.Team = competitions[i][winnerIndex];
            currentChampion.Points = leaderboards[competitions[i][winnerIndex]];
        }
        return currentChampion.Team;
    }
}