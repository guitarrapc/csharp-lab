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
| **Stopwatch**      | **1**      |  **61.81 ns** | **2.665 ns** | **0.146 ns** |  **61.70 ns** |  **61.97 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.43 ns | 0.233 ns | 0.013 ns |  57.43 ns |  57.45 ns |      - |         - |
| **Stopwatch**      | **3**      | **120.59 ns** | **5.040 ns** | **0.276 ns** | **120.41 ns** | **120.91 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.69 ns | 1.880 ns | 0.103 ns | 114.62 ns | 114.80 ns |      - |         - |
