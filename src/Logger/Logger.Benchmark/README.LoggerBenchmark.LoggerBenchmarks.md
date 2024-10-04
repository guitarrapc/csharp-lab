```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **61.31 ns** |  **1.753 ns** | **0.096 ns** |  **61.20 ns** |  **61.38 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  60.12 ns |  4.109 ns | 0.225 ns |  59.93 ns |  60.37 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  67.08 ns |  3.869 ns | 0.212 ns |  66.94 ns |  67.32 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.96 ns |  1.091 ns | 0.060 ns |  19.90 ns |  20.02 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.97 ns |  1.593 ns | 0.087 ns |  19.91 ns |  20.07 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.15 ns |  1.747 ns | 0.096 ns |  19.07 ns |  19.26 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **183.92 ns** | **14.963 ns** | **0.820 ns** | **183.06 ns** | **184.69 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 181.76 ns | 12.712 ns | 0.697 ns | 181.19 ns | 182.53 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 203.45 ns |  6.374 ns | 0.349 ns | 203.09 ns | 203.79 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.34 ns |  3.913 ns | 0.215 ns |  59.20 ns |  59.59 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.66 ns |  0.863 ns | 0.047 ns |  58.62 ns |  58.71 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.26 ns |  0.371 ns | 0.020 ns |  57.24 ns |  57.28 ns |      - |         - |
