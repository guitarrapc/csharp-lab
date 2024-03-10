```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **61.34 ns** | **0.735 ns** | **0.040 ns** |  **61.31 ns** |  **61.39 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.13 ns | 0.169 ns | 0.009 ns |  57.12 ns |  57.14 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.71 ns** | **4.905 ns** | **0.269 ns** | **119.40 ns** | **119.89 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.10 ns | 1.742 ns | 0.095 ns | 114.03 ns | 114.21 ns |      - |         - |
