```

BenchmarkDotNet v0.13.6, Windows 11 (10.0.22621.1992/22H2/2022Update/SunValley2)
12th Gen Intel Core i9-12900H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 7.0.202
  [Host]     : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2


```
|                     Method |     Mean |    Error |   StdDev | Allocated |
|--------------------------- |---------:|---------:|---------:|----------:|
|                       Swap | 172.5 μs | 10.92 μs | 32.19 μs |     160 B |
| SwapWithOptimizationLevel1 | 177.7 μs |  6.04 μs | 17.51 μs |     160 B |
| SwapWithOptimizationLevel2 | 187.6 μs |  5.41 μs | 15.69 μs |     160 B |
