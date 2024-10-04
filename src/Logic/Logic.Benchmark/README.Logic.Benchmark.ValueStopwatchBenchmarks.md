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
| **Stopwatch**      | **1**      |  **61.67 ns** | **2.078 ns** | **0.114 ns** |  **61.55 ns** |  **61.77 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.48 ns | 1.230 ns | 0.067 ns |  57.44 ns |  57.56 ns |      - |         - |
| **Stopwatch**      | **3**      | **120.40 ns** | **5.139 ns** | **0.282 ns** | **120.12 ns** | **120.68 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.59 ns | 0.341 ns | 0.019 ns | 114.58 ns | 114.61 ns |      - |         - |
