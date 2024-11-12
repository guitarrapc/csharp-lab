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
| **LogWithoutIfParams**                         | **1**      |  **62.12 ns** | **31.733 ns** | **1.739 ns** |  **60.67 ns** |  **64.05 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  60.18 ns |  2.499 ns | 0.137 ns |  60.06 ns |  60.33 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  66.30 ns |  5.349 ns | 0.293 ns |  65.96 ns |  66.51 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.91 ns |  1.090 ns | 0.060 ns |  19.84 ns |  19.95 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.97 ns |  0.806 ns | 0.044 ns |  19.95 ns |  20.03 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.31 ns |  1.937 ns | 0.106 ns |  19.24 ns |  19.43 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **187.60 ns** | **54.143 ns** | **2.968 ns** | **185.58 ns** | **191.01 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 180.38 ns |  8.806 ns | 0.483 ns | 179.83 ns | 180.68 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 196.86 ns |  2.691 ns | 0.148 ns | 196.75 ns | 197.03 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  58.99 ns |  2.472 ns | 0.135 ns |  58.90 ns |  59.15 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.36 ns |  1.592 ns | 0.087 ns |  58.29 ns |  58.46 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.70 ns |  2.056 ns | 0.113 ns |  57.58 ns |  57.79 ns |      - |         - |
