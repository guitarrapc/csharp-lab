```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **63.90 ns** | **1.881 ns** | **0.103 ns** |  **63.82 ns** |  **64.01 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.41 ns | 1.222 ns | 0.067 ns |  57.37 ns |  57.49 ns |      - |         - |
| **Stopwatch**      | **3**      | **120.52 ns** | **9.436 ns** | **0.517 ns** | **120.11 ns** | **121.10 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.28 ns | 5.712 ns | 0.313 ns | 114.02 ns | 114.63 ns |      - |         - |
