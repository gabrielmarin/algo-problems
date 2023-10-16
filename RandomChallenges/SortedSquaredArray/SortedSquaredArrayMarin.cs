namespace RandomChallenges.SortedSquaredArray
{
    public static class SortedSquaredArrayMarin
    {
        public static int[] SortedSquaredArray(int[] inputArray)
        {
            var resultArray = new int[inputArray.Length];
            for (var i = 0; i < inputArray.Length; i++)
            {
                resultArray[i] = inputArray[i] * inputArray[i];
            }

            Array.Sort(resultArray);
            return resultArray;
        }
    }
}
