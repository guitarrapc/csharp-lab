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
| **Stopwatch**      | **1**      |  **61.63 ns** | **2.103 ns** | **0.115 ns** |  **61.51 ns** |  **61.73 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.02 ns | 0.387 ns | 0.021 ns |  57.01 ns |  57.04 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.70 ns** | **4.186 ns** | **0.229 ns** | **119.53 ns** | **119.96 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.00 ns | 0.441 ns | 0.024 ns | 113.97 ns | 114.02 ns |      - |         - |
