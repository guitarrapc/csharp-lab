```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **61.19 ns** | **4.452 ns** | **0.244 ns** |  **60.97 ns** |  **61.45 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.14 ns | 0.104 ns | 0.006 ns |  57.13 ns |  57.14 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.43 ns** | **4.536 ns** | **0.249 ns** | **119.18 ns** | **119.68 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 113.74 ns | 0.798 ns | 0.044 ns | 113.69 ns | 113.78 ns |      - |         - |
