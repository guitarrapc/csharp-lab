```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **65.09 ns** |  **5.938 ns** | **0.325 ns** |  **64.72 ns** |  **65.33 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.32 ns |  4.620 ns | 0.253 ns |  59.04 ns |  59.53 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  66.73 ns | 29.736 ns | 1.630 ns |  65.66 ns |  68.60 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  20.07 ns |  4.381 ns | 0.240 ns |  19.88 ns |  20.34 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.90 ns |  0.845 ns | 0.046 ns |  19.85 ns |  19.94 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.12 ns |  2.681 ns | 0.147 ns |  18.98 ns |  19.27 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **184.75 ns** | **11.921 ns** | **0.653 ns** | **184.17 ns** | **185.46 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 177.75 ns |  3.300 ns | 0.181 ns | 177.62 ns | 177.96 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 195.67 ns |  6.338 ns | 0.347 ns | 195.31 ns | 196.00 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  58.94 ns |  4.984 ns | 0.273 ns |  58.66 ns |  59.21 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  59.66 ns | 32.302 ns | 1.771 ns |  58.22 ns |  61.63 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.72 ns |  2.322 ns | 0.127 ns |  57.64 ns |  57.86 ns |      - |         - |
