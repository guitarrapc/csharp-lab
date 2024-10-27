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
| **Stopwatch**      | **1**      |  **62.24 ns** | **3.322 ns** | **0.182 ns** |  **62.12 ns** |  **62.45 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.16 ns | 0.348 ns | 0.019 ns |  57.14 ns |  57.17 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.88 ns** | **8.291 ns** | **0.454 ns** | **119.57 ns** | **120.40 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 113.85 ns | 4.321 ns | 0.237 ns | 113.71 ns | 114.12 ns |      - |         - |
