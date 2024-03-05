```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **60.92 ns** |  **8.756 ns** | **0.480 ns** |  **60.37 ns** |  **61.27 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.10 ns |  2.204 ns | 0.121 ns |  58.96 ns |  59.17 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  65.38 ns |  1.632 ns | 0.089 ns |  65.31 ns |  65.48 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.92 ns |  3.567 ns | 0.196 ns |  19.79 ns |  20.15 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.94 ns |  1.168 ns | 0.064 ns |  19.87 ns |  19.99 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.44 ns |  5.453 ns | 0.299 ns |  19.16 ns |  19.75 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **182.23 ns** | **61.084 ns** | **3.348 ns** | **179.72 ns** | **186.03 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 177.18 ns | 32.245 ns | 1.767 ns | 176.01 ns | 179.21 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 193.69 ns |  7.608 ns | 0.417 ns | 193.31 ns | 194.14 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.30 ns |  4.509 ns | 0.247 ns |  59.01 ns |  59.47 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.25 ns |  0.427 ns | 0.023 ns |  58.23 ns |  58.28 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  59.09 ns |  1.608 ns | 0.088 ns |  59.04 ns |  59.20 ns |      - |         - |
