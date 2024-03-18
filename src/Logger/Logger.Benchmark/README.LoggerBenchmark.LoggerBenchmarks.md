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
| **LogWithoutIfParams**                         | **1**      |  **60.66 ns** |  **2.915 ns** | **0.160 ns** |  **60.47 ns** |  **60.75 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  60.50 ns | 42.319 ns | 2.320 ns |  58.89 ns |  63.16 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  64.79 ns |  5.110 ns | 0.280 ns |  64.61 ns |  65.11 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.93 ns |  2.025 ns | 0.111 ns |  19.86 ns |  20.06 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.80 ns |  0.132 ns | 0.007 ns |  19.80 ns |  19.81 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.14 ns |  0.076 ns | 0.004 ns |  19.13 ns |  19.14 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **178.96 ns** |  **7.219 ns** | **0.396 ns** | **178.59 ns** | **179.37 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 176.01 ns |  2.062 ns | 0.113 ns | 175.90 ns | 176.12 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 203.84 ns | 47.404 ns | 2.598 ns | 201.62 ns | 206.70 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.01 ns |  0.827 ns | 0.045 ns |  58.98 ns |  59.06 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.69 ns |  4.884 ns | 0.268 ns |  58.50 ns |  59.00 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  58.99 ns |  1.188 ns | 0.065 ns |  58.93 ns |  59.05 ns |      - |         - |
