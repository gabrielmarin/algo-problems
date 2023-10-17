using BenchmarkDotNet.Attributes;
using RandomChallenges.MindBodyChallenge;

namespace RandomChallenges.PerformanceTests.Benchmarks;

[MemoryDiagnoser]
public class MindBodyChallengeBenchmark
{
    private int _maxLength;
    private string _inputMessage;

    [GlobalSetup]
    public void Setup()
    {
        _inputMessage = "There is an animal with four legs";
        _maxLength = 15;
    }

    [Benchmark]
    public string ParseMessageWithSubstring()
    {
        return MindBodyChallengeClass.ParseMessageNotificationV1(_inputMessage, _maxLength);
    }
    
    [Benchmark]
    public string ParseMessageWithSpan()
    {
        return MindBodyChallengeClass.ParseMessageNotificationV2(_inputMessage, _maxLength);
    }
}