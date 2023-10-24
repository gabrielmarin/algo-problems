namespace RandomChallenges.FromAlgoExpert.ValidateSubsequence;

public class ValidateSubsequenceChallenge
{
    // array = [5,1,22,25,6,-1,8,10]
    // sequence = [1,6,-1,10]
    // output = true
    public static bool IsValidSubsequence(List<int> array, List<int> sequence)
    {
        var sequenceIndex = 0; 
        foreach (var item in array)
        {
            if(item == sequence[sequenceIndex]) sequenceIndex++;
            if (sequenceIndex == sequence.Count) return true;
        }
        return sequenceIndex == sequence.Count;
    }
}