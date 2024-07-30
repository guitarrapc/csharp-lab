```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **63.64 ns** |   **8.494 ns** | **0.466 ns** |  **63.32 ns** |  **64.17 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  60.19 ns |   4.511 ns | 0.247 ns |  59.90 ns |  60.36 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  66.37 ns |   7.942 ns | 0.435 ns |  66.07 ns |  66.87 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  21.15 ns |   3.241 ns | 0.178 ns |  21.04 ns |  21.36 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.81 ns |   0.315 ns | 0.017 ns |  19.79 ns |  19.83 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.29 ns |   0.313 ns | 0.017 ns |  19.27 ns |  19.30 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **182.34 ns** |   **8.908 ns** | **0.488 ns** | **181.82 ns** | **182.79 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 187.65 ns |  34.076 ns | 1.868 ns | 186.31 ns | 189.78 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 209.27 ns | 101.220 ns | 5.548 ns | 204.50 ns | 215.36 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.04 ns |   1.198 ns | 0.066 ns |  58.99 ns |  59.11 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.21 ns |   0.309 ns | 0.017 ns |  58.20 ns |  58.23 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.77 ns |   2.052 ns | 0.112 ns |  57.67 ns |  57.89 ns |      - |         - |
