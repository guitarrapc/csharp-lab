```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **58.21 ns** |  **3.291 ns** | **0.180 ns** |  **58.01 ns** |  **58.37 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  58.69 ns |  1.145 ns | 0.063 ns |  58.62 ns |  58.75 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  70.56 ns |  7.319 ns | 0.401 ns |  70.31 ns |  71.03 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.82 ns |  2.065 ns | 0.113 ns |  19.76 ns |  19.95 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  20.00 ns |  2.343 ns | 0.128 ns |  19.90 ns |  20.14 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.15 ns |  0.092 ns | 0.005 ns |  19.14 ns |  19.15 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **173.73 ns** |  **4.892 ns** | **0.268 ns** | **173.43 ns** | **173.94 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 177.76 ns | 10.124 ns | 0.555 ns | 177.40 ns | 178.40 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 192.66 ns |  5.198 ns | 0.285 ns | 192.43 ns | 192.98 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.35 ns |  3.935 ns | 0.216 ns |  59.19 ns |  59.60 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  59.01 ns |  2.485 ns | 0.136 ns |  58.88 ns |  59.15 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.41 ns |  1.167 ns | 0.064 ns |  57.36 ns |  57.48 ns |      - |         - |
