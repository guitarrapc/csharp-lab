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
| **LogWithoutIfParams**                         | **1**      |  **61.13 ns** |  **3.419 ns** | **0.187 ns** |  **60.94 ns** |  **61.32 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  60.16 ns |  0.747 ns | 0.041 ns |  60.13 ns |  60.21 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  66.50 ns | 10.466 ns | 0.574 ns |  65.93 ns |  67.08 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  20.06 ns |  4.821 ns | 0.264 ns |  19.88 ns |  20.36 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.80 ns |  0.420 ns | 0.023 ns |  19.77 ns |  19.81 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.41 ns |  4.071 ns | 0.223 ns |  19.27 ns |  19.67 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **181.65 ns** |  **2.051 ns** | **0.112 ns** | **181.54 ns** | **181.76 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 184.72 ns | 94.474 ns | 5.178 ns | 180.79 ns | 190.58 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 200.61 ns | 39.454 ns | 2.163 ns | 198.95 ns | 203.05 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.24 ns |  2.524 ns | 0.138 ns |  59.12 ns |  59.39 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.89 ns | 18.469 ns | 1.012 ns |  58.24 ns |  60.05 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.16 ns |  1.146 ns | 0.063 ns |  57.09 ns |  57.21 ns |      - |         - |
