namespace RandomChallenges.SortedSquaredArray
{
    public class SortedSquaredArrayChallengeGeo
    {
        public int[] SortedSquaredArray { get; set; }

        public int[] SortedArray { get; set; }

        public SortedSquaredArrayChallengeGeo(int[] sortedArray)
        {
            SortedSquaredArray = new int[sortedArray.Length];
            SortedArray = sortedArray;
        }

        public void ComputeArray()
        {
            for (var i = 0; i < SortedArray.Length; i++)
            {
                SortedSquaredArray[i] = SortedArray[i] * SortedArray[i];
            }

            Array.Sort(SortedSquaredArray);
        }
    }
}
