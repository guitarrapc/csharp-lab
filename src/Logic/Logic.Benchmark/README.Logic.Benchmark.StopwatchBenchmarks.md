```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **60.23 ns** | **1.409 ns** | **0.077 ns** |  **60.14 ns** |  **60.28 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  55.87 ns | 0.101 ns | 0.006 ns |  55.87 ns |  55.88 ns |      - |         - |
| **Stopwatch**      | **10**     | **316.60 ns** | **9.194 ns** | **0.504 ns** | **316.29 ns** | **317.19 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     | 308.48 ns | 1.008 ns | 0.055 ns | 308.42 ns | 308.53 ns |      - |         - |
