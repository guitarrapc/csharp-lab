```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **65.55 ns** |  **20.092 ns** | **1.101 ns** |  **64.56 ns** |  **66.74 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  60.58 ns |   1.417 ns | 0.078 ns |  60.52 ns |  60.67 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  66.86 ns |   1.260 ns | 0.069 ns |  66.81 ns |  66.94 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  20.05 ns |   5.826 ns | 0.319 ns |  19.81 ns |  20.41 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.97 ns |   0.621 ns | 0.034 ns |  19.93 ns |  20.00 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.30 ns |   0.268 ns | 0.015 ns |  19.28 ns |  19.31 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **188.97 ns** | **131.475 ns** | **7.207 ns** | **181.59 ns** | **195.99 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 181.25 ns |   4.998 ns | 0.274 ns | 180.95 ns | 181.48 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 199.02 ns |  43.396 ns | 2.379 ns | 197.55 ns | 201.76 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.04 ns |   1.535 ns | 0.084 ns |  58.98 ns |  59.13 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.35 ns |   1.143 ns | 0.063 ns |  58.31 ns |  58.42 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.67 ns |   1.697 ns | 0.093 ns |  57.60 ns |  57.77 ns |      - |         - |
