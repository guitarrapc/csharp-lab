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
| **Stopwatch**      | **1**      |  **61.47 ns** | **2.537 ns** | **0.139 ns** |  **61.35 ns** |  **61.62 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.10 ns | 0.106 ns | 0.006 ns |  57.09 ns |  57.10 ns |      - |         - |
| **Stopwatch**      | **3**      | **120.14 ns** | **5.794 ns** | **0.318 ns** | **119.87 ns** | **120.49 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.36 ns | 2.744 ns | 0.150 ns | 114.27 ns | 114.54 ns |      - |         - |
