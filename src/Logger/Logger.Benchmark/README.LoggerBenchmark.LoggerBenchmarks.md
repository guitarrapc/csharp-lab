```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **60.40 ns** |  **0.679 ns** | **0.037 ns** |  **60.36 ns** |  **60.43 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.76 ns |  7.008 ns | 0.384 ns |  59.47 ns |  60.19 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  68.18 ns | 32.748 ns | 1.795 ns |  66.74 ns |  70.19 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.95 ns |  1.906 ns | 0.104 ns |  19.85 ns |  20.05 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.99 ns |  1.204 ns | 0.066 ns |  19.95 ns |  20.06 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.26 ns |  0.159 ns | 0.009 ns |  19.26 ns |  19.27 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **179.55 ns** |  **5.504 ns** | **0.302 ns** | **179.32 ns** | **179.89 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 177.91 ns |  8.080 ns | 0.443 ns | 177.50 ns | 178.38 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 197.57 ns | 50.974 ns | 2.794 ns | 195.89 ns | 200.79 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.40 ns |  5.373 ns | 0.295 ns |  59.18 ns |  59.73 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.21 ns |  0.871 ns | 0.048 ns |  58.16 ns |  58.25 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.70 ns |  1.367 ns | 0.075 ns |  57.64 ns |  57.79 ns |      - |         - |
