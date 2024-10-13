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
| **Stopwatch**      | **1**      |  **61.29 ns** | **3.299 ns** | **0.181 ns** |  **61.17 ns** |  **61.49 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.16 ns | 0.439 ns | 0.024 ns |  57.14 ns |  57.19 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.57 ns** | **5.264 ns** | **0.289 ns** | **119.40 ns** | **119.90 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.68 ns | 2.144 ns | 0.118 ns | 114.61 ns | 114.82 ns |      - |         - |
