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
| **Stopwatch**      | **1**      |  **61.96 ns** | **5.138 ns** | **0.282 ns** |  **61.72 ns** |  **62.27 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  56.98 ns | 5.744 ns | 0.315 ns |  56.79 ns |  57.34 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.77 ns** | **5.055 ns** | **0.277 ns** | **119.54 ns** | **120.08 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.36 ns | 2.710 ns | 0.149 ns | 114.27 ns | 114.54 ns |      - |         - |
