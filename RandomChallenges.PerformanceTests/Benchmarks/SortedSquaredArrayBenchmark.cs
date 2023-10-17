using BenchmarkDotNet.Attributes;
using RandomChallenges.SortedSquaredArray;

namespace RandomChallenges.PerformanceTests.Benchmarks;

[MemoryDiagnoser]
public class SortedSquaredArrayBenchmark
{
    private int[] _inputArray;

    [Params(100, 10_000)]
    public int Size { get; set; }
    
    [GlobalSetup]
    public void Setup()
    {
        var rnd = new Random(420);
        _inputArray = Enumerable.Range(0, Size)
            .Select(x => rnd.Next(-1000, 1000))
            .ToArray();
        
        Array.Sort(_inputArray);
    }

    [Benchmark]
    public int[] SquaredArrayEasyWay()
    {
        return SortedSquaredArrayMarin.SortedSquaredArrayEasyWay(_inputArray);
    }
    
    [Benchmark]
    public int[] SquaredArrayEfficientWay()
    {
        return SortedSquaredArrayMarin.SortedSquaredArrayEfficientWay(_inputArray);
    }
}