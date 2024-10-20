```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **61.28 ns** |  **7.548 ns** | **0.414 ns** |  **60.99 ns** |  **61.76 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  60.73 ns |  5.863 ns | 0.321 ns |  60.40 ns |  61.04 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  65.81 ns |  2.758 ns | 0.151 ns |  65.64 ns |  65.91 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.89 ns |  0.258 ns | 0.014 ns |  19.87 ns |  19.90 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  20.01 ns |  1.685 ns | 0.092 ns |  19.94 ns |  20.12 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.33 ns |  0.402 ns | 0.022 ns |  19.31 ns |  19.36 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **180.50 ns** | **11.643 ns** | **0.638 ns** | **180.03 ns** | **181.23 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 178.74 ns | 20.929 ns | 1.147 ns | 177.61 ns | 179.90 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 205.89 ns |  3.725 ns | 0.204 ns | 205.74 ns | 206.12 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.32 ns |  3.011 ns | 0.165 ns |  59.14 ns |  59.47 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.24 ns |  0.926 ns | 0.051 ns |  58.18 ns |  58.27 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.09 ns |  1.655 ns | 0.091 ns |  57.00 ns |  57.18 ns |      - |         - |
