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
| **LogWithoutIfParams**                         | **1**      |  **61.31 ns** |  **5.908 ns** | **0.324 ns** |  **60.95 ns** |  **61.57 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  62.49 ns |  4.834 ns | 0.265 ns |  62.21 ns |  62.74 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  67.72 ns |  7.156 ns | 0.392 ns |  67.45 ns |  68.17 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  20.13 ns |  1.708 ns | 0.094 ns |  20.05 ns |  20.24 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.96 ns |  1.753 ns | 0.096 ns |  19.90 ns |  20.07 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.30 ns |  0.466 ns | 0.026 ns |  19.28 ns |  19.33 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **186.24 ns** | **13.958 ns** | **0.765 ns** | **185.73 ns** | **187.12 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 182.37 ns |  5.612 ns | 0.308 ns | 182.03 ns | 182.63 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 200.63 ns | 32.771 ns | 1.796 ns | 199.42 ns | 202.70 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.83 ns |  6.116 ns | 0.335 ns |  59.63 ns |  60.21 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  59.15 ns |  9.314 ns | 0.511 ns |  58.61 ns |  59.63 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.36 ns |  2.288 ns | 0.125 ns |  57.28 ns |  57.50 ns |      - |         - |
