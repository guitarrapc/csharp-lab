```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **61.98 ns** | **2.552 ns** | **0.140 ns** |  **61.85 ns** |  **62.13 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.11 ns | 0.361 ns | 0.020 ns |  57.09 ns |  57.13 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.84 ns** | **4.735 ns** | **0.260 ns** | **119.69 ns** | **120.14 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.04 ns | 0.341 ns | 0.019 ns | 114.02 ns | 114.06 ns |      - |         - |
