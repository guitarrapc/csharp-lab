```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **66.22 ns** |  **6.787 ns** | **0.372 ns** |  **65.79 ns** |  **66.45 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.98 ns |  3.435 ns | 0.188 ns |  59.76 ns |  60.12 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  66.82 ns | 17.038 ns | 0.934 ns |  66.22 ns |  67.89 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  20.11 ns |  8.738 ns | 0.479 ns |  19.79 ns |  20.66 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.93 ns |  0.259 ns | 0.014 ns |  19.92 ns |  19.94 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.27 ns |  1.175 ns | 0.064 ns |  19.20 ns |  19.33 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **183.50 ns** | **14.747 ns** | **0.808 ns** | **182.84 ns** | **184.40 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 183.41 ns |  4.787 ns | 0.262 ns | 183.11 ns | 183.62 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 205.63 ns | 63.786 ns | 3.496 ns | 201.60 ns | 207.82 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.26 ns |  4.602 ns | 0.252 ns |  58.98 ns |  59.46 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.63 ns |  2.847 ns | 0.156 ns |  58.49 ns |  58.80 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.27 ns |  1.793 ns | 0.098 ns |  57.19 ns |  57.38 ns |      - |         - |
