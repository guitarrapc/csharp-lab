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
| **Stopwatch**      | **1**      |  **61.11 ns** |  **3.045 ns** | **0.167 ns** |  **60.93 ns** |  **61.26 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  55.83 ns |  0.540 ns | 0.030 ns |  55.80 ns |  55.86 ns |      - |         - |
| **Stopwatch**      | **10**     | **317.26 ns** | **10.472 ns** | **0.574 ns** | **316.61 ns** | **317.71 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     | 308.45 ns |  0.651 ns | 0.036 ns | 308.41 ns | 308.49 ns |      - |         - |
