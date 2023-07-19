

using BenchmarkDotNet.Running;
using TupleUsage.SwapNumber;

//new SwapTwoNumber().Swap();
//new SwapTwoNumber().SwapWithOptimizationLevel1();
//new SwapTwoNumber().SwapWithOptimizationLevel2();

BenchmarkRunner.Run<SwapTwoNumber>();

/// <benchmark-result>
/// | Method                      | Mean      | Error     | StdDev    | Allocated  |
/// | --------------------------- | ---------:| ---------:| ---------:| ----------:|
/// | Swap                        | 172.5 us  | 10.92 us  | 32.19 us  | 160 B      |
/// | SwapWithOptimizationLevel1  | 177.7 us  | 6.04 us   | 17.51 us  | 160 B      |
/// | SwapWithOptimizationLevel2  | 187.6 us  | 5.41 us   | 15.69 us  | 160 B      |
/// </benchmark-result>