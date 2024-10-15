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
| **Stopwatch**      | **1**      |  **61.35 ns** |  **2.597 ns** | **0.142 ns** |  **61.18 ns** |  **61.44 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.25 ns |  1.416 ns | 0.078 ns |  57.20 ns |  57.34 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.62 ns** |  **9.620 ns** | **0.527 ns** | **119.32 ns** | **120.23 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 116.49 ns | 10.991 ns | 0.602 ns | 115.80 ns | 116.89 ns |      - |         - |
