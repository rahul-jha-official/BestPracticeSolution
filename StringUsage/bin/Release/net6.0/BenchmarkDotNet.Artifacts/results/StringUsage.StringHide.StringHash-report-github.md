```

BenchmarkDotNet v0.13.6, Windows 11 (10.0.22621.1992/22H2/2022Update/SunValley2)
12th Gen Intel Core i9-12900H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 7.0.202
  [Host]     : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2


```
|                                           Method |      Mean |    Error |   StdDev |   Gen0 | Allocated |
|------------------------------------------------- |----------:|---------:|---------:|-------:|----------:|
|                      StringHashOridinarySolution | 184.59 ns | 1.433 ns | 1.340 ns | 0.0801 |    1008 B |
| StringHashOridinarySolutionWithOpimizationLevel1 |  42.51 ns | 0.189 ns | 0.158 ns | 0.0249 |     312 B |
| StringHashOridinarySolutionWithOpimizationLevel2 |  20.11 ns | 0.154 ns | 0.144 ns | 0.0134 |     168 B |
| StringHashOridinarySolutionWithOpimizationLevel3 |  10.18 ns | 0.082 ns | 0.069 ns | 0.0108 |     136 B |
