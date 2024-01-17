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
| **Stopwatch**      | **1**      |  **60.90 ns** |  **3.493 ns** | **0.191 ns** |  **60.72 ns** |  **61.10 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  55.80 ns |  0.153 ns | 0.008 ns |  55.79 ns |  55.81 ns |      - |         - |
| **Stopwatch**      | **10**     | **316.78 ns** |  **9.661 ns** | **0.530 ns** | **316.45 ns** | **317.39 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     | 308.95 ns | 16.883 ns | 0.925 ns | 308.39 ns | 310.02 ns |      - |         - |
