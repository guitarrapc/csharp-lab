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
| **LogWithoutIfParams**                         | **1**      |  **60.32 ns** |  **6.435 ns** | **0.353 ns** |  **59.99 ns** |  **60.69 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  60.74 ns |  1.752 ns | 0.096 ns |  60.64 ns |  60.83 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  68.16 ns | 32.846 ns | 1.800 ns |  67.04 ns |  70.24 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  20.02 ns |  7.826 ns | 0.429 ns |  19.77 ns |  20.52 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.97 ns |  0.880 ns | 0.048 ns |  19.93 ns |  20.02 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.42 ns |  0.079 ns | 0.004 ns |  19.42 ns |  19.43 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **182.23 ns** | **10.348 ns** | **0.567 ns** | **181.58 ns** | **182.61 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 182.39 ns | 41.224 ns | 2.260 ns | 181.00 ns | 185.00 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 195.63 ns |  7.908 ns | 0.433 ns | 195.25 ns | 196.10 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.19 ns |  3.652 ns | 0.200 ns |  59.03 ns |  59.41 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.34 ns |  0.907 ns | 0.050 ns |  58.29 ns |  58.39 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.74 ns |  1.034 ns | 0.057 ns |  57.70 ns |  57.80 ns |      - |         - |
