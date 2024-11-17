```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **61.90 ns** |  **2.254 ns** | **0.124 ns** |  **61.80 ns** |  **62.04 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.81 ns |  1.559 ns | 0.085 ns |  59.72 ns |  59.89 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  67.24 ns |  1.369 ns | 0.075 ns |  67.18 ns |  67.32 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.81 ns |  0.803 ns | 0.044 ns |  19.78 ns |  19.86 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.82 ns |  0.483 ns | 0.026 ns |  19.79 ns |  19.85 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.20 ns |  2.217 ns | 0.122 ns |  19.13 ns |  19.34 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **181.15 ns** | **15.536 ns** | **0.852 ns** | **180.17 ns** | **181.69 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 182.24 ns | 48.442 ns | 2.655 ns | 180.33 ns | 185.28 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 199.94 ns |  1.295 ns | 0.071 ns | 199.86 ns | 199.99 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  85.51 ns |  0.217 ns | 0.012 ns |  85.50 ns |  85.52 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.89 ns |  2.315 ns | 0.127 ns |  58.79 ns |  59.03 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  59.83 ns |  0.897 ns | 0.049 ns |  59.79 ns |  59.88 ns |      - |         - |
