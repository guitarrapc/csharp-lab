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
| **Stopwatch**      | **1**      |  **60.24 ns** |  **5.014 ns** | **0.275 ns** |  **60.03 ns** |  **60.55 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  55.93 ns |  2.133 ns | 0.117 ns |  55.86 ns |  56.07 ns |      - |         - |
| **Stopwatch**      | **10**     | **316.88 ns** | **13.038 ns** | **0.715 ns** | **316.13 ns** | **317.55 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     | 308.41 ns |  2.766 ns | 0.152 ns | 308.32 ns | 308.58 ns |      - |         - |
