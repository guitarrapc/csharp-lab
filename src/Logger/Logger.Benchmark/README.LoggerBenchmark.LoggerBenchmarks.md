```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **60.87 ns** |  **12.613 ns** |  **0.691 ns** |  **60.35 ns** |  **61.65 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.45 ns |   5.654 ns |  0.310 ns |  59.10 ns |  59.67 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  64.88 ns |   0.901 ns |  0.049 ns |  64.83 ns |  64.92 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  20.02 ns |   2.146 ns |  0.118 ns |  19.89 ns |  20.13 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.80 ns |   1.060 ns |  0.058 ns |  19.73 ns |  19.84 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.64 ns |  12.307 ns |  0.675 ns |  19.12 ns |  20.40 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **179.22 ns** |  **18.419 ns** |  **1.010 ns** | **178.55 ns** | **180.38 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 178.42 ns |  45.208 ns |  2.478 ns | 176.33 ns | 181.16 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 207.04 ns | 215.582 ns | 11.817 ns | 193.42 ns | 214.53 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  58.92 ns |   0.315 ns |  0.017 ns |  58.91 ns |  58.94 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.28 ns |   2.577 ns |  0.141 ns |  58.19 ns |  58.44 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.77 ns |   2.063 ns |  0.113 ns |  57.70 ns |  57.90 ns |      - |         - |
