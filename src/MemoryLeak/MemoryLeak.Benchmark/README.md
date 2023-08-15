# MemoryLeak.Benchmark.NoAllocMemoryLeakBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon CPU E5-2673 v3 2.40GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT
  ShortRun : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|            Method | Number |        Mean |     Error |    StdDev |         Min |         Max | Allocated |
|------------------ |------- |------------:|----------:|----------:|------------:|------------:|----------:|
|        **RentReturn** |      **1** |    **59.51 ns** |  **18.81 ns** |  **1.031 ns** |    **58.44 ns** |    **60.50 ns** |         **-** |
| AllocateArrayPool |      1 |   217.19 ns |  12.24 ns |  0.671 ns |   216.49 ns |   217.83 ns |         - |
|        **RentReturn** |     **10** | **1,022.68 ns** | **523.51 ns** | **28.695 ns** | **1,001.30 ns** | **1,055.29 ns** |         **-** |
| AllocateArrayPool |     10 | 1,553.18 ns | 203.00 ns | 11.127 ns | 1,540.93 ns | 1,562.66 ns |         - |
# MemoryLeak.Benchmark.MemoryLeakBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon CPU E5-2673 v3 2.40GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT
  ShortRun : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|               Method | Number |        Mean |       Error |      StdDev |         Min |         Max |  Gen 0 |  Gen 1 |  Gen 2 | Allocated |
|--------------------- |------- |------------:|------------:|------------:|------------:|------------:|-------:|-------:|-------:|----------:|
| **AllocateStringStatic** |      **1** |  **1,067.4 ns** |  **1,055.7 ns** |    **57.86 ns** |  **1,033.4 ns** |  **1,134.2 ns** | **0.0668** | **0.0648** |      **-** |      **1 KB** |
|       AllocateString |      1 |  1,059.2 ns |    373.9 ns |    20.50 ns |  1,045.3 ns |  1,082.8 ns | 0.0668 | 0.0648 |      - |      1 KB |
|          AllocateLoH |      1 |  1,021.6 ns |    928.4 ns |    50.89 ns |    978.0 ns |  1,077.5 ns | 0.0668 | 0.0648 |      - |      1 KB |
|        AllocateArray |      1 |  1,055.8 ns |    450.9 ns |    24.72 ns |  1,040.9 ns |  1,084.4 ns | 0.0668 | 0.0648 |      - |      1 KB |
|    AllocateArrayPool |      1 |    996.9 ns |    574.7 ns |    31.50 ns |    970.0 ns |  1,031.6 ns | 0.0668 | 0.0648 |      - |      1 KB |
| **AllocateStringStatic** |     **10** | **13,370.5 ns** | **67,780.9 ns** | **3,715.30 ns** | **11,011.6 ns** | **17,653.2 ns** | **0.6714** | **0.6561** | **0.0153** |     **10 KB** |
|       AllocateString |     10 | 10,747.9 ns |  5,181.2 ns |   284.00 ns | 10,468.2 ns | 11,036.0 ns | 0.6714 | 0.6561 | 0.0153 |     10 KB |
|          AllocateLoH |     10 |  9,938.8 ns | 10,152.4 ns |   556.49 ns |  9,391.7 ns | 10,504.3 ns | 0.6714 | 0.6561 | 0.0153 |     10 KB |
|        AllocateArray |     10 | 10,768.8 ns |  8,864.0 ns |   485.87 ns | 10,289.1 ns | 11,260.6 ns | 0.6714 | 0.6561 | 0.0153 |     10 KB |
|    AllocateArrayPool |     10 | 10,728.3 ns |  8,004.8 ns |   438.77 ns | 10,382.8 ns | 11,222.0 ns | 0.6714 | 0.6561 | 0.0153 |     10 KB |
