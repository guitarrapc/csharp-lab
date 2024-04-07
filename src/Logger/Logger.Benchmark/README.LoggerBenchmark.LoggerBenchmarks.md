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
| **LogWithoutIfParams**                         | **1**      |  **62.29 ns** |  **1.328 ns** | **0.073 ns** |  **62.21 ns** |  **62.35 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  63.24 ns | 26.235 ns | 1.438 ns |  62.25 ns |  64.89 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  65.17 ns |  7.720 ns | 0.423 ns |  64.70 ns |  65.51 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  20.97 ns |  0.467 ns | 0.026 ns |  20.95 ns |  21.00 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  30.09 ns |  0.896 ns | 0.049 ns |  30.06 ns |  30.14 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.29 ns |  0.883 ns | 0.048 ns |  19.26 ns |  19.35 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **181.07 ns** | **10.928 ns** | **0.599 ns** | **180.38 ns** | **181.46 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 179.01 ns | 30.110 ns | 1.650 ns | 177.67 ns | 180.86 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 193.57 ns |  9.654 ns | 0.529 ns | 193.05 ns | 194.11 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.45 ns |  5.461 ns | 0.299 ns |  59.26 ns |  59.79 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.28 ns |  2.333 ns | 0.128 ns |  58.19 ns |  58.42 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.67 ns |  0.480 ns | 0.026 ns |  57.65 ns |  57.70 ns |      - |         - |
