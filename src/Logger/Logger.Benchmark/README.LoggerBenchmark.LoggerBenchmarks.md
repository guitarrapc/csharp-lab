```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **71.71 ns** |  **0.273 ns** | **0.015 ns** |  **71.70 ns** |  **71.72 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.22 ns |  1.231 ns | 0.067 ns |  59.17 ns |  59.30 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  66.27 ns | 22.077 ns | 1.210 ns |  65.44 ns |  67.66 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  20.03 ns |  5.289 ns | 0.290 ns |  19.86 ns |  20.37 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.75 ns |  0.441 ns | 0.024 ns |  19.72 ns |  19.77 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.14 ns |  0.074 ns | 0.004 ns |  19.14 ns |  19.15 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **181.48 ns** |  **3.728 ns** | **0.204 ns** | **181.30 ns** | **181.70 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 184.89 ns |  4.863 ns | 0.267 ns | 184.59 ns | 185.09 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 198.36 ns |  5.333 ns | 0.292 ns | 198.14 ns | 198.69 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.10 ns |  0.734 ns | 0.040 ns |  59.05 ns |  59.13 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.27 ns |  1.368 ns | 0.075 ns |  58.22 ns |  58.36 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.29 ns |  2.473 ns | 0.136 ns |  57.15 ns |  57.42 ns |      - |         - |
