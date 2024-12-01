```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **62.22 ns** |  **8.335 ns** | **0.457 ns** |  **61.93 ns** |  **62.75 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  63.39 ns |  2.991 ns | 0.164 ns |  63.23 ns |  63.56 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  65.55 ns |  1.851 ns | 0.101 ns |  65.43 ns |  65.63 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.77 ns |  0.207 ns | 0.011 ns |  19.76 ns |  19.78 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.89 ns |  0.200 ns | 0.011 ns |  19.88 ns |  19.90 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.15 ns |  0.790 ns | 0.043 ns |  19.12 ns |  19.20 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **179.86 ns** |  **7.015 ns** | **0.385 ns** | **179.61 ns** | **180.30 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 178.91 ns | 29.344 ns | 1.608 ns | 177.67 ns | 180.73 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 205.14 ns | 81.989 ns | 4.494 ns | 202.16 ns | 210.31 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.05 ns | 10.430 ns | 0.572 ns |  58.71 ns |  59.71 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.30 ns |  0.375 ns | 0.021 ns |  58.28 ns |  58.32 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.82 ns |  4.589 ns | 0.252 ns |  57.66 ns |  58.11 ns |      - |         - |
