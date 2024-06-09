```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **61.29 ns** | **2.095 ns** | **0.115 ns** |  **61.16 ns** |  **61.39 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.27 ns | 2.237 ns | 0.123 ns |  59.17 ns |  59.41 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  67.86 ns | 2.278 ns | 0.125 ns |  67.72 ns |  67.96 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.93 ns | 2.576 ns | 0.141 ns |  19.84 ns |  20.09 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.96 ns | 1.267 ns | 0.069 ns |  19.91 ns |  20.04 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.33 ns | 2.970 ns | 0.163 ns |  19.23 ns |  19.52 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **179.42 ns** | **4.258 ns** | **0.233 ns** | **179.15 ns** | **179.57 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 177.40 ns | 3.056 ns | 0.167 ns | 177.20 ns | 177.50 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 195.59 ns | 7.950 ns | 0.436 ns | 195.09 ns | 195.86 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.46 ns | 2.423 ns | 0.133 ns |  59.36 ns |  59.61 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.27 ns | 0.918 ns | 0.050 ns |  58.23 ns |  58.32 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.76 ns | 0.882 ns | 0.048 ns |  57.70 ns |  57.79 ns |      - |         - |
