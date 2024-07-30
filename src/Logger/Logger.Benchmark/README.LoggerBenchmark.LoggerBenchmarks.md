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
| **LogWithoutIfParams**                         | **1**      |  **62.14 ns** |  **3.241 ns** | **0.178 ns** |  **61.98 ns** |  **62.33 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.93 ns | 13.532 ns | 0.742 ns |  59.50 ns |  60.78 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  69.02 ns | 16.113 ns | 0.883 ns |  68.46 ns |  70.04 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.91 ns |  2.327 ns | 0.128 ns |  19.82 ns |  20.05 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  20.02 ns |  4.509 ns | 0.247 ns |  19.86 ns |  20.31 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.62 ns | 14.717 ns | 0.807 ns |  19.15 ns |  20.55 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **181.93 ns** |  **7.403 ns** | **0.406 ns** | **181.62 ns** | **182.39 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 185.32 ns |  8.471 ns | 0.464 ns | 184.94 ns | 185.84 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 202.93 ns | 28.794 ns | 1.578 ns | 201.94 ns | 204.75 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.29 ns |  5.409 ns | 0.296 ns |  59.10 ns |  59.63 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.22 ns |  0.820 ns | 0.045 ns |  58.17 ns |  58.26 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.81 ns |  2.671 ns | 0.146 ns |  57.65 ns |  57.94 ns |      - |         - |
