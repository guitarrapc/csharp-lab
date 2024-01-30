```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **60.21 ns** |  **4.717 ns** | **0.259 ns** |  **60.05 ns** |  **60.51 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  55.83 ns |  0.747 ns | 0.041 ns |  55.79 ns |  55.87 ns |      - |         - |
| **Stopwatch**      | **10**     | **317.28 ns** |  **9.790 ns** | **0.537 ns** | **316.69 ns** | **317.74 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     | 309.34 ns | 13.910 ns | 0.762 ns | 308.81 ns | 310.22 ns |      - |         - |
