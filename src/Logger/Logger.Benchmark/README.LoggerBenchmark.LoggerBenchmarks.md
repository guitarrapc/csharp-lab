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
| **LogWithoutIfParams**                         | **1**      |  **60.80 ns** |  **2.386 ns** | **0.131 ns** |  **60.72 ns** |  **60.95 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.45 ns |  3.615 ns | 0.198 ns |  59.25 ns |  59.64 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  68.68 ns |  6.435 ns | 0.353 ns |  68.38 ns |  69.07 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.80 ns |  0.871 ns | 0.048 ns |  19.77 ns |  19.86 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.81 ns |  0.076 ns | 0.004 ns |  19.81 ns |  19.81 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.45 ns |  0.641 ns | 0.035 ns |  19.41 ns |  19.48 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **179.19 ns** | **10.443 ns** | **0.572 ns** | **178.60 ns** | **179.75 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 182.97 ns | 10.161 ns | 0.557 ns | 182.37 ns | 183.47 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 200.66 ns |  8.906 ns | 0.488 ns | 200.25 ns | 201.20 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  58.98 ns |  1.428 ns | 0.078 ns |  58.92 ns |  59.07 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.39 ns |  0.261 ns | 0.014 ns |  58.38 ns |  58.41 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.18 ns |  1.609 ns | 0.088 ns |  57.12 ns |  57.28 ns |      - |         - |
