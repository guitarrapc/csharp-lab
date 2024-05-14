```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **61.60 ns** | **2.580 ns** | **0.141 ns** |  **61.48 ns** |  **61.76 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.14 ns | 0.501 ns | 0.027 ns |  57.11 ns |  57.17 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.97 ns** | **5.398 ns** | **0.296 ns** | **119.68 ns** | **120.27 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.10 ns | 2.235 ns | 0.123 ns | 113.98 ns | 114.22 ns |      - |         - |
