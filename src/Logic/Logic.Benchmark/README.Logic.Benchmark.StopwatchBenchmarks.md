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
| **Stopwatch**      | **1**      |  **60.44 ns** |  **2.803 ns** | **0.154 ns** |  **60.31 ns** |  **60.61 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  55.58 ns |  0.530 ns | 0.029 ns |  55.56 ns |  55.61 ns |      - |         - |
| **Stopwatch**      | **10**     | **316.93 ns** | **10.645 ns** | **0.583 ns** | **316.56 ns** | **317.60 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     | 308.39 ns |  2.673 ns | 0.147 ns | 308.30 ns | 308.56 ns |      - |         - |
