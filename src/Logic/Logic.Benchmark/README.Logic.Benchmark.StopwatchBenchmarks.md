```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **60.50 ns** |  **2.857 ns** | **0.157 ns** |  **60.32 ns** |  **60.59 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  55.77 ns |  2.112 ns | 0.116 ns |  55.70 ns |  55.91 ns |      - |         - |
| **Stopwatch**      | **10**     | **316.88 ns** | **10.691 ns** | **0.586 ns** | **316.53 ns** | **317.55 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     | 308.40 ns |  0.391 ns | 0.021 ns | 308.38 ns | 308.42 ns |      - |         - |
