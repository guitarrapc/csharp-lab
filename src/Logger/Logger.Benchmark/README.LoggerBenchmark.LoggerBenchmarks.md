```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **69.66 ns** | **56.927 ns** | **3.120 ns** |  **67.75 ns** |  **73.26 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.73 ns |  1.990 ns | 0.109 ns |  59.61 ns |  59.80 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  68.62 ns |  5.618 ns | 0.308 ns |  68.32 ns |  68.93 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.85 ns |  0.031 ns | 0.002 ns |  19.85 ns |  19.86 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  20.17 ns |  4.700 ns | 0.258 ns |  20.00 ns |  20.46 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.19 ns |  1.016 ns | 0.056 ns |  19.13 ns |  19.24 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **185.91 ns** | **73.796 ns** | **4.045 ns** | **183.08 ns** | **190.54 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 180.75 ns | 17.803 ns | 0.976 ns | 180.05 ns | 181.87 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 201.57 ns | 97.791 ns | 5.360 ns | 198.43 ns | 207.76 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.07 ns |  3.974 ns | 0.218 ns |  58.92 ns |  59.32 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.22 ns |  0.435 ns | 0.024 ns |  58.19 ns |  58.24 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.30 ns |  1.494 ns | 0.082 ns |  57.25 ns |  57.40 ns |      - |         - |
