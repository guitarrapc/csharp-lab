```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **59.72 ns** |  **1.948 ns** | **0.107 ns** |  **59.60 ns** |  **59.79 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.98 ns |  5.573 ns | 0.306 ns |  59.65 ns |  60.26 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  64.82 ns |  3.717 ns | 0.204 ns |  64.61 ns |  65.01 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  20.26 ns |  2.534 ns | 0.139 ns |  20.14 ns |  20.41 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.95 ns |  0.738 ns | 0.040 ns |  19.92 ns |  19.99 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.27 ns |  1.207 ns | 0.066 ns |  19.19 ns |  19.31 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **185.83 ns** | **18.045 ns** | **0.989 ns** | **184.70 ns** | **186.51 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 176.49 ns |  2.065 ns | 0.113 ns | 176.39 ns | 176.61 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 196.68 ns | 10.034 ns | 0.550 ns | 196.27 ns | 197.30 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.12 ns |  2.572 ns | 0.141 ns |  59.01 ns |  59.28 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.22 ns |  0.817 ns | 0.045 ns |  58.17 ns |  58.26 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.22 ns |  2.919 ns | 0.160 ns |  57.03 ns |  57.32 ns |      - |         - |
