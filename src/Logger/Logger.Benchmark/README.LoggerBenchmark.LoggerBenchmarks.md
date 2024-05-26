```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **59.43 ns** |  **2.444 ns** | **0.134 ns** |  **59.31 ns** |  **59.58 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.27 ns |  3.538 ns | 0.194 ns |  59.14 ns |  59.50 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  65.75 ns |  2.404 ns | 0.132 ns |  65.63 ns |  65.90 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.94 ns |  2.257 ns | 0.124 ns |  19.87 ns |  20.08 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.94 ns |  0.265 ns | 0.015 ns |  19.93 ns |  19.95 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.63 ns | 12.303 ns | 0.674 ns |  19.20 ns |  20.41 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **180.35 ns** | **43.598 ns** | **2.390 ns** | **178.33 ns** | **182.99 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 188.07 ns | 52.067 ns | 2.854 ns | 186.05 ns | 191.34 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 199.33 ns |  6.096 ns | 0.334 ns | 198.95 ns | 199.57 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.21 ns |  0.715 ns | 0.039 ns |  59.17 ns |  59.24 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.30 ns |  1.093 ns | 0.060 ns |  58.23 ns |  58.34 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.73 ns |  1.620 ns | 0.089 ns |  57.68 ns |  57.84 ns |      - |         - |
