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
| **LogWithoutIfParams**                         | **1**      |  **64.46 ns** |  **6.796 ns** | **0.373 ns** |  **64.20 ns** |  **64.89 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  62.67 ns |  6.708 ns | 0.368 ns |  62.36 ns |  63.07 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  65.35 ns |  1.829 ns | 0.100 ns |  65.24 ns |  65.44 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.94 ns |  1.551 ns | 0.085 ns |  19.88 ns |  20.04 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.98 ns |  2.159 ns | 0.118 ns |  19.91 ns |  20.12 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.32 ns |  0.484 ns | 0.027 ns |  19.29 ns |  19.34 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **187.82 ns** | **13.371 ns** | **0.733 ns** | **187.02 ns** | **188.47 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 185.61 ns |  8.480 ns | 0.465 ns | 185.28 ns | 186.14 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 198.99 ns |  9.538 ns | 0.523 ns | 198.38 ns | 199.32 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.27 ns |  1.089 ns | 0.060 ns |  59.23 ns |  59.34 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.59 ns |  0.132 ns | 0.007 ns |  58.59 ns |  58.60 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.38 ns |  3.061 ns | 0.168 ns |  57.27 ns |  57.57 ns |      - |         - |
