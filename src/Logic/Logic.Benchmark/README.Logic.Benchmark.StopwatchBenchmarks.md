```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **60.47 ns** | **2.674 ns** | **0.147 ns** |  **60.36 ns** |  **60.63 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  55.93 ns | 0.910 ns | 0.050 ns |  55.87 ns |  55.97 ns |      - |         - |
| **Stopwatch**      | **10**     | **316.62 ns** | **9.675 ns** | **0.530 ns** | **316.29 ns** | **317.23 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     | 308.49 ns | 0.325 ns | 0.018 ns | 308.48 ns | 308.51 ns |      - |         - |
