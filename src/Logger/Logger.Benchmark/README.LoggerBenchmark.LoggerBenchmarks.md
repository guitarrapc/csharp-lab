```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **63.02 ns** | **14.069 ns** | **0.771 ns** |  **62.40 ns** |  **63.88 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  60.87 ns |  1.259 ns | 0.069 ns |  60.82 ns |  60.95 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  66.76 ns |  2.607 ns | 0.143 ns |  66.68 ns |  66.93 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.82 ns |  0.876 ns | 0.048 ns |  19.79 ns |  19.88 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.94 ns |  4.834 ns | 0.265 ns |  19.77 ns |  20.24 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.33 ns |  0.950 ns | 0.052 ns |  19.30 ns |  19.39 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **182.95 ns** |  **7.672 ns** | **0.421 ns** | **182.68 ns** | **183.44 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 197.46 ns |  6.010 ns | 0.329 ns | 197.08 ns | 197.65 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 198.17 ns | 10.205 ns | 0.559 ns | 197.63 ns | 198.75 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.30 ns |  0.848 ns | 0.046 ns |  59.25 ns |  59.34 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  59.06 ns | 26.791 ns | 1.469 ns |  58.21 ns |  60.75 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.55 ns |  0.211 ns | 0.012 ns |  57.55 ns |  57.57 ns |      - |         - |
