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
| **Stopwatch**      | **1**      |  **60.20 ns** | **4.282 ns** | **0.235 ns** |  **60.06 ns** |  **60.47 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  55.92 ns | 1.150 ns | 0.063 ns |  55.87 ns |  55.99 ns |      - |         - |
| **Stopwatch**      | **10**     | **316.71 ns** | **9.446 ns** | **0.518 ns** | **316.22 ns** | **317.25 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     | 308.47 ns | 1.550 ns | 0.085 ns | 308.40 ns | 308.56 ns |      - |         - |
