namespace RandomChallenges.SortedSquaredArray
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
            //-10, -5, 0, 5, 10
            //
            
            var resultArray = new int[inputArray.Length];
            var j = inputArray.Length - 1;
            for (var i = 0; i < inputArray.Length; i++)
            {
                resultArray[i] = inputArray[i] * inputArray[i];
            }

            Array.Sort(resultArray);
            return resultArray;
        }
    }
}
