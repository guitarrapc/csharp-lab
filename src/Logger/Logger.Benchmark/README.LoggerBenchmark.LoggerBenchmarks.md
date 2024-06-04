```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **60.58 ns** |  **4.887 ns** | **0.268 ns** |  **60.33 ns** |  **60.86 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.02 ns |  2.757 ns | 0.151 ns |  58.85 ns |  59.13 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  64.89 ns |  4.090 ns | 0.224 ns |  64.73 ns |  65.14 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  20.09 ns |  4.146 ns | 0.227 ns |  19.89 ns |  20.34 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  30.29 ns |  0.811 ns | 0.044 ns |  30.26 ns |  30.34 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.54 ns |  5.891 ns | 0.323 ns |  19.33 ns |  19.91 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **178.92 ns** | **16.660 ns** | **0.913 ns** | **177.86 ns** | **179.47 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 176.69 ns | 10.163 ns | 0.557 ns | 176.06 ns | 177.11 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 195.74 ns | 56.955 ns | 3.122 ns | 193.93 ns | 199.35 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.07 ns |  1.971 ns | 0.108 ns |  58.98 ns |  59.19 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.82 ns | 18.621 ns | 1.021 ns |  58.19 ns |  60.00 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.67 ns |  1.585 ns | 0.087 ns |  57.57 ns |  57.73 ns |      - |         - |
