using BenchmarkDotNet.Attributes;

namespace TupleUsage.SwapNumber;

[MemoryDiagnoser]
public class SwapTwoNumber
{
    private int n1 = 10;
    private int n2 = 20;

    [Benchmark]
    public void Swap()
    {
        Console.WriteLine($"Before Swap (n1: {n1}, n2: {n2})");
        int temp = n1;
        n1 = n2;
        n2 = temp;
        Console.WriteLine($"After Swap (n1: {n1}, n2: {n2})");
    }

    [Benchmark]
    public void SwapWithOptimizationLevel1()
    {
        Console.WriteLine($"Before Swap (n1: {n1}, n2: {n2})");
        n1 = n1 + n2;
        n2 = n1 - n2;
        n1 = n1 - n2;
        Console.WriteLine($"After Swap (n1: {n1}, n2: {n2})");
    }

    [Benchmark]
    public void SwapWithOptimizationLevel2()
    {
        Console.WriteLine($"Before Swap (n1: {n1}, n2: {n2})");
        (n1, n2) = (n2, n1);
        Console.WriteLine($"After Swap (n1: {n1}, n2: {n2})");
    }
}
