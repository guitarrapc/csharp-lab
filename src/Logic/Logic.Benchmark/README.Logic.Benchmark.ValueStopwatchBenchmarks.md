```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **61.57 ns** | **2.199 ns** | **0.121 ns** |  **61.49 ns** |  **61.71 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.11 ns | 0.425 ns | 0.023 ns |  57.10 ns |  57.14 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.67 ns** | **5.192 ns** | **0.285 ns** | **119.47 ns** | **120.00 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 113.99 ns | 0.148 ns | 0.008 ns | 113.98 ns | 114.00 ns |      - |         - |
