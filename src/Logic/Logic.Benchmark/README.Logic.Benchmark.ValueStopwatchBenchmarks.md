```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **61.21 ns** |  **1.876 ns** | **0.103 ns** |  **61.14 ns** |  **61.33 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.19 ns |  2.194 ns | 0.120 ns |  57.12 ns |  57.33 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.78 ns** | **12.456 ns** | **0.683 ns** | **119.31 ns** | **120.57 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 113.68 ns |  0.299 ns | 0.016 ns | 113.66 ns | 113.69 ns |      - |         - |
