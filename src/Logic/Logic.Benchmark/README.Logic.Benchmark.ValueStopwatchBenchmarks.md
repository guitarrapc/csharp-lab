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
| **Stopwatch**      | **1**      |  **61.36 ns** | **3.160 ns** | **0.173 ns** |  **61.24 ns** |  **61.56 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.11 ns | 0.138 ns | 0.008 ns |  57.10 ns |  57.12 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.98 ns** | **9.681 ns** | **0.531 ns** | **119.47 ns** | **120.52 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.02 ns | 1.591 ns | 0.087 ns | 113.95 ns | 114.11 ns |      - |         - |
