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
| **LogWithoutIfParams**                         | **1**      |  **61.42 ns** | **27.206 ns** | **1.491 ns** |  **60.46 ns** |  **63.14 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.85 ns |  3.653 ns | 0.200 ns |  59.71 ns |  60.08 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  68.27 ns | 57.127 ns | 3.131 ns |  65.61 ns |  71.72 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  20.11 ns | 10.201 ns | 0.559 ns |  19.78 ns |  20.76 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.70 ns |  0.115 ns | 0.006 ns |  19.69 ns |  19.70 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.56 ns |  3.924 ns | 0.215 ns |  19.41 ns |  19.80 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **181.90 ns** | **30.442 ns** | **1.669 ns** | **180.51 ns** | **183.75 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 176.83 ns | 11.003 ns | 0.603 ns | 176.42 ns | 177.53 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 199.52 ns | 13.539 ns | 0.742 ns | 199.02 ns | 200.38 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.04 ns |  1.217 ns | 0.067 ns |  58.98 ns |  59.11 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.22 ns |  0.301 ns | 0.017 ns |  58.21 ns |  58.24 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.48 ns |  1.691 ns | 0.093 ns |  57.38 ns |  57.54 ns |      - |         - |
