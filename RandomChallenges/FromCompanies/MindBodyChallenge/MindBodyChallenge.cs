namespace RandomChallenges.FromCompanies.MindBodyChallenge;
//inputMessage, maxLength, expectedResult
//And now here is my secret, 15, "And now ..."
//There is an animal with four legs, 15, "There is an ..."
public static class MindBodyChallengeClass
{
    public static string ParseMessageNotificationV1(string message, int maxLength)
    {
        if (message.Length <= maxLength) return message;
        var croppedMsg = message.Substring(0, maxLength - 3);
        var lastSpaceIndex = croppedMsg.LastIndexOf(' ');
        return croppedMsg.Substring(0, lastSpaceIndex + 1) + "...";
    }
    public static string ParseMessageNotificationV2(string message, int maxLength)
    {
        if (message.Length <= maxLength) return message;
        var croppedMsg = message.AsSpan(0, maxLength - 3);
        var lastSpaceIndex = croppedMsg.LastIndexOf(' ');
        return string.Concat(croppedMsg[..(lastSpaceIndex + 1)], stackalloc[] {'.', '.', '.'});
    }
}