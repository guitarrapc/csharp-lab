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
| **LogWithoutIfParams**                         | **1**      |  **63.64 ns** | **18.136 ns** | **0.994 ns** |  **62.94 ns** |  **64.78 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.89 ns |  2.739 ns | 0.150 ns |  59.74 ns |  60.04 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  65.25 ns |  0.985 ns | 0.054 ns |  65.20 ns |  65.31 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.91 ns |  0.431 ns | 0.024 ns |  19.88 ns |  19.93 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.97 ns |  0.532 ns | 0.029 ns |  19.95 ns |  20.00 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.29 ns |  1.460 ns | 0.080 ns |  19.22 ns |  19.38 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **181.45 ns** | **10.308 ns** | **0.565 ns** | **181.01 ns** | **182.09 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 194.66 ns |  1.517 ns | 0.083 ns | 194.58 ns | 194.75 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 194.83 ns |  5.408 ns | 0.296 ns | 194.55 ns | 195.14 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.40 ns |  8.159 ns | 0.447 ns |  59.06 ns |  59.91 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.24 ns |  0.719 ns | 0.039 ns |  58.20 ns |  58.28 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.72 ns |  1.657 ns | 0.091 ns |  57.64 ns |  57.82 ns |      - |         - |
