```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **61.88 ns** |  **2.840 ns** | **0.156 ns** |  **61.72 ns** |  **62.03 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  60.14 ns |  1.176 ns | 0.064 ns |  60.08 ns |  60.21 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  65.80 ns |  3.300 ns | 0.181 ns |  65.68 ns |  66.00 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.82 ns |  0.218 ns | 0.012 ns |  19.80 ns |  19.82 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.82 ns |  0.261 ns | 0.014 ns |  19.81 ns |  19.84 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.29 ns |  0.187 ns | 0.010 ns |  19.28 ns |  19.30 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **182.87 ns** |  **6.241 ns** | **0.342 ns** | **182.54 ns** | **183.22 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 197.97 ns |  5.887 ns | 0.323 ns | 197.63 ns | 198.27 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 199.05 ns | 27.063 ns | 1.483 ns | 198.00 ns | 200.75 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.28 ns |  3.742 ns | 0.205 ns |  59.14 ns |  59.52 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.30 ns |  2.669 ns | 0.146 ns |  58.21 ns |  58.47 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.14 ns |  2.063 ns | 0.113 ns |  57.07 ns |  57.27 ns |      - |         - |
