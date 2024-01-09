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
| **Stopwatch**      | **1**      |  **61.02 ns** | **23.930 ns** | **1.312 ns** |  **60.15 ns** |  **62.53 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  55.88 ns |  0.412 ns | 0.023 ns |  55.86 ns |  55.90 ns |      - |         - |
| **Stopwatch**      | **10**     | **317.18 ns** |  **8.275 ns** | **0.454 ns** | **316.66 ns** | **317.47 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     | 308.46 ns |  1.420 ns | 0.078 ns | 308.40 ns | 308.55 ns |      - |         - |
