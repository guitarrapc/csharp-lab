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
| **Stopwatch**      | **1**      |  **61.91 ns** | **3.083 ns** | **0.169 ns** |  **61.79 ns** |  **62.10 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.44 ns | 0.400 ns | 0.022 ns |  57.42 ns |  57.47 ns |      - |         - |
| **Stopwatch**      | **3**      | **120.45 ns** | **5.422 ns** | **0.297 ns** | **120.27 ns** | **120.80 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.60 ns | 0.186 ns | 0.010 ns | 114.59 ns | 114.61 ns |      - |         - |
