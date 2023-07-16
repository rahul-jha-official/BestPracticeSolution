// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Running;
using StringUsage.StringHide;

//var s = new StringHash();
//Console.WriteLine(s.GetOriginal());
//Console.WriteLine(s.StringHashOridinarySolution());
//Console.WriteLine(s.StringHashOridinarySolutionWithOpimizationLevel1());
//Console.WriteLine(s.StringHashOridinarySolutionWithOpimizationLevel2());
//Console.WriteLine(s.StringHashOridinarySolutionWithOpimizationLevel3());

BenchmarkRunner.Run<StringHash>();

/// <benchmark>
/// <class>StringHash</class>
/// <cpu>
/// <processor>12th Gen Intel(R) Core(TM) i9-12900H   2.90 GHz</processor>
/// </cpu>
/// <result>
/// |   Method                                              | Mean          | Error         | StdDev        | Gen0          | Allocated     |
/// |   -------------------------------------------------   | ------------- | ------------- | ------------- | ------------- | ------------- |
/// |   StringHashOridinarySolution                         | 174.10 ns     | 1.369 ns      | 1.213 ns      | 0.0801        | 1008 B        |
/// |   StringHashOridinarySolutionWithOpimizationLevel1    | 42.54 ns      | 0.566 ns      | 0.530 ns      | 0.0249        | 312 B         |
/// |   StringHashOridinarySolutionWithOpimizationLevel2    | 20.32 ns      | 0.263 ns      | 0.246 ns      | 0.0134        | 168 B         |
/// |   StringHashOridinarySolutionWithOpimizationLevel3    | 10.64 ns      | 0.233 ns      | 0.303 ns      | 0.0108        | 136 B         |
/// </result>
/// </benchmark>
