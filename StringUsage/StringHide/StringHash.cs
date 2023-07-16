using BenchmarkDotNet.Attributes;
using System.Text;

namespace StringUsage.StringHide;

[MemoryDiagnoser]
public class StringHash
{
    private readonly string OriginalPassword = "IAmTheBestProgrammer123";
    private readonly int firstNHide = 5;

    public string GetOriginal()
    {
        return OriginalPassword;
    }
    [Benchmark]
    public string StringHashOridinarySolution()
    {
        string stringHash = string.Empty;
        stringHash += OriginalPassword.Substring(0, firstNHide);
        for (int i = 1; i <= OriginalPassword.Length - firstNHide; i++)
        {
            stringHash += "*";
        }
        return stringHash;
    }

    [Benchmark]
    public string StringHashOridinarySolutionWithOpimizationLevel1()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(OriginalPassword.Substring(0, firstNHide));
        for (int i = 1; i <= OriginalPassword.Length - firstNHide; i++)
        {
            sb.Append('*');
        }
        return sb.ToString();
    }

    [Benchmark]
    public string StringHashOridinarySolutionWithOpimizationLevel2()
    {
        string stars = new('*', OriginalPassword.Length - firstNHide);
        return OriginalPassword.Substring(0, firstNHide) + stars;
    }

    [Benchmark]
    public string StringHashOridinarySolutionWithOpimizationLevel3()
    {
        return string.Create(OriginalPassword.Length, OriginalPassword, (span, value) =>
        {
            value.AsSpan().CopyTo(span);
            span[firstNHide..].Fill('*');
        });
    }
}
