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
| **LogWithoutIfParams**                         | **1**      |  **60.95 ns** |  **5.781 ns** | **0.317 ns** |  **60.73 ns** |  **61.31 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  60.49 ns |  3.653 ns | 0.200 ns |  60.27 ns |  60.66 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  67.16 ns | 29.817 ns | 1.634 ns |  66.16 ns |  69.04 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.93 ns |  1.131 ns | 0.062 ns |  19.89 ns |  20.00 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.98 ns |  1.268 ns | 0.069 ns |  19.93 ns |  20.06 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.25 ns |  1.013 ns | 0.056 ns |  19.18 ns |  19.28 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **180.64 ns** |  **7.678 ns** | **0.421 ns** | **180.19 ns** | **181.03 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 182.88 ns | 51.540 ns | 2.825 ns | 179.62 ns | 184.62 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 195.49 ns | 15.018 ns | 0.823 ns | 194.87 ns | 196.43 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.16 ns |  2.307 ns | 0.126 ns |  59.07 ns |  59.31 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.99 ns | 21.549 ns | 1.181 ns |  58.26 ns |  60.36 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.30 ns |  6.328 ns | 0.347 ns |  57.09 ns |  57.70 ns |      - |         - |
