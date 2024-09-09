```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **62.57 ns** | **13.449 ns** | **0.737 ns** |  **61.93 ns** |  **63.38 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  58.95 ns |  5.734 ns | 0.314 ns |  58.74 ns |  59.31 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  64.85 ns |  7.535 ns | 0.413 ns |  64.61 ns |  65.33 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.82 ns |  0.418 ns | 0.023 ns |  19.79 ns |  19.84 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.94 ns |  2.053 ns | 0.113 ns |  19.87 ns |  20.07 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.19 ns |  0.623 ns | 0.034 ns |  19.16 ns |  19.23 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **183.19 ns** | **40.761 ns** | **2.234 ns** | **181.43 ns** | **185.70 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 188.66 ns | 25.175 ns | 1.380 ns | 187.39 ns | 190.13 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 197.06 ns |  2.057 ns | 0.113 ns | 196.93 ns | 197.15 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.06 ns |  0.675 ns | 0.037 ns |  59.03 ns |  59.10 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.31 ns |  1.123 ns | 0.062 ns |  58.24 ns |  58.36 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.83 ns |  1.771 ns | 0.097 ns |  57.76 ns |  57.94 ns |      - |         - |
