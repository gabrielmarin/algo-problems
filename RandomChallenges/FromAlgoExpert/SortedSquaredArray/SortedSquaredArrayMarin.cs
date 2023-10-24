namespace RandomChallenges.FromAlgoExpert.SortedSquaredArray
{
    public static class SortedSquaredArrayMarin
    {
        public static int[] SortedSquaredArrayEasyWay(int[] inputArray)
        {
            var resultArray = new int[inputArray.Length];
            for (var i = 0; i < inputArray.Length; i++)
            {
                resultArray[i] = inputArray[i] * inputArray[i];
            }

            Array.Sort(resultArray);
            return resultArray;
        }
        
        public static int[] SortedSquaredArrayEfficientWay(int[] inputArray)
        {
            var resultArray = new int[inputArray.Length];
            var upperBoundIndex = inputArray.Length-1;
            var lowerBoundIndex = 0;
            for(var i = inputArray.Length-1; i >= 0; i--)
            {
                if (Math.Abs(inputArray[upperBoundIndex]) >= Math.Abs(inputArray[lowerBoundIndex]))
                {
                    resultArray[i] = inputArray[upperBoundIndex] * inputArray[upperBoundIndex];
                    upperBoundIndex--;
                    continue;
                }

                resultArray[i] = inputArray[lowerBoundIndex] * inputArray[lowerBoundIndex];
                lowerBoundIndex++;
            }
            return resultArray;
        }
    }
}
