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
| **LogWithoutIfParams**                         | **1**      |  **60.82 ns** | **11.846 ns** | **0.649 ns** |  **60.33 ns** |  **61.56 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.33 ns |  3.123 ns | 0.171 ns |  59.16 ns |  59.51 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  66.76 ns | 22.125 ns | 1.213 ns |  65.57 ns |  67.99 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.99 ns |  3.535 ns | 0.194 ns |  19.86 ns |  20.22 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.93 ns |  0.142 ns | 0.008 ns |  19.92 ns |  19.94 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.38 ns |  2.772 ns | 0.152 ns |  19.29 ns |  19.55 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **183.84 ns** | **25.098 ns** | **1.376 ns** | **182.41 ns** | **185.15 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 181.00 ns |  9.100 ns | 0.499 ns | 180.50 ns | 181.49 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 200.90 ns | 73.921 ns | 4.052 ns | 198.49 ns | 205.58 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.17 ns |  0.924 ns | 0.051 ns |  59.14 ns |  59.23 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.24 ns |  0.240 ns | 0.013 ns |  58.23 ns |  58.26 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.71 ns |  5.281 ns | 0.289 ns |  57.40 ns |  57.98 ns |      - |         - |
