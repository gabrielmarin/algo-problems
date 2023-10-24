namespace RandomChallenges.FromAlgoExpert.NonConstructibleChange;

public class NonConstructibleChangeChallenge
{
    //I struggled a freaking lot with this one and wasn't able to solved all of it till the end by myself
    //I got right the sorting part and the currentChange variable idea, but not the "coin > currentChange + 1" rule
    //time complexity O(n log n) due to the sorting step
    //space complexity O(1), since there wasn't a need to create another data structure to manipulate the data
    public static int NonConstructibleChange(int[] coins)
    {
        if(coins.Length == 0) return 1;
        Array.Sort(coins);
        var currentChange = 0;
        foreach (var coin in coins)
        {
            if(coin > currentChange + 1) return currentChange + 1;
            currentChange += coin;
        }
        
        return ++currentChange;
    }
}