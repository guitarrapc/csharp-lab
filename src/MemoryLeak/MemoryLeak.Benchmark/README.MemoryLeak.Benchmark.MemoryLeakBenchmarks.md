```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **754.7 ns** |   **929.3 ns** | **50.94 ns** |   **716.7 ns** |   **812.6 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   760.9 ns |   102.9 ns |  5.64 ns |   754.6 ns |   765.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   724.3 ns |   264.8 ns | 14.51 ns |   708.6 ns |   737.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   748.3 ns |   519.7 ns | 28.48 ns |   731.0 ns |   781.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   725.3 ns |   432.7 ns | 23.72 ns |   698.1 ns |   741.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,231.4 ns** | **1,193.6 ns** | **65.42 ns** | **2,175.9 ns** | **2,303.5 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,251.8 ns | 1,362.9 ns | 74.70 ns | 2,182.3 ns | 2,330.8 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,089.3 ns | 1,811.1 ns | 99.27 ns | 1,997.1 ns | 2,194.4 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,155.8 ns | 1,139.1 ns | 62.44 ns | 2,084.2 ns | 2,198.4 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,200.3 ns | 1,268.8 ns | 69.55 ns | 2,120.8 ns | 2,249.8 ns | 0.0343 | 0.0305 |   3.07 KB |
