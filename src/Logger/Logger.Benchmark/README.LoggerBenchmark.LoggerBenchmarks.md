```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **63.54 ns** | **65.113 ns** | **3.569 ns** |  **61.26 ns** |  **67.66 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.75 ns |  3.241 ns | 0.178 ns |  59.60 ns |  59.95 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  68.34 ns |  3.672 ns | 0.201 ns |  68.11 ns |  68.47 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.94 ns |  3.091 ns | 0.169 ns |  19.84 ns |  20.14 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.74 ns |  0.609 ns | 0.033 ns |  19.72 ns |  19.78 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.28 ns |  0.491 ns | 0.027 ns |  19.26 ns |  19.31 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **179.06 ns** | **11.043 ns** | **0.605 ns** | **178.67 ns** | **179.75 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 181.86 ns | 60.490 ns | 3.316 ns | 178.12 ns | 184.46 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 196.13 ns | 11.873 ns | 0.651 ns | 195.38 ns | 196.51 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.01 ns |  1.493 ns | 0.082 ns |  58.94 ns |  59.10 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.26 ns |  1.858 ns | 0.102 ns |  58.20 ns |  58.38 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  59.49 ns |  2.567 ns | 0.141 ns |  59.40 ns |  59.65 ns |      - |         - |
