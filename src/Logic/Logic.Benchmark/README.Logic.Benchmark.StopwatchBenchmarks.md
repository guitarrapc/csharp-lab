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
| **Stopwatch**      | **1**      |  **60.85 ns** |  **1.570 ns** | **0.086 ns** |  **60.77 ns** |  **60.94 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  55.90 ns |  0.401 ns | 0.022 ns |  55.88 ns |  55.92 ns |      - |         - |
| **Stopwatch**      | **10**     | **316.78 ns** | **10.471 ns** | **0.574 ns** | **316.37 ns** | **317.44 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     | 308.85 ns | 10.355 ns | 0.568 ns | 308.49 ns | 309.50 ns |      - |         - |
