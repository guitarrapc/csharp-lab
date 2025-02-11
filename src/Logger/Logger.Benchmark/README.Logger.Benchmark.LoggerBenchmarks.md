```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]            : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                                     | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **.NET 8.0** | **1**      |  **61.73 ns** | **15.938 ns** | **0.874 ns** |  **61.11 ns** |  **62.73 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | .NET 8.0 | 1      |  61.94 ns | 52.512 ns | 2.878 ns |  59.94 ns |  65.23 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 1      |  58.38 ns |  4.058 ns | 0.222 ns |  58.15 ns |  58.59 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 1      |  19.95 ns |  1.124 ns | 0.062 ns |  19.91 ns |  20.02 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 1      |  20.00 ns |  1.612 ns | 0.088 ns |  19.90 ns |  20.08 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 1      |  19.40 ns |  0.680 ns | 0.037 ns |  19.36 ns |  19.43 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 1      |  55.69 ns |  6.082 ns | 0.333 ns |  55.43 ns |  56.07 ns | 0.0052 |      88 B |
| LogWithIfParams                            | .NET 9.0 | 1      |  56.13 ns |  7.665 ns | 0.420 ns |  55.69 ns |  56.53 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 1      |  56.12 ns |  1.871 ns | 0.103 ns |  56.00 ns |  56.18 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 1      |  20.15 ns |  2.939 ns | 0.161 ns |  19.97 ns |  20.27 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 1      |  20.16 ns |  1.737 ns | 0.095 ns |  20.10 ns |  20.27 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 1      |  19.28 ns |  0.678 ns | 0.037 ns |  19.25 ns |  19.32 ns |      - |         - |
| **LogWithoutIfParams**                         | **.NET 8.0** | **3**      | **177.77 ns** | **57.763 ns** | **3.166 ns** | **174.49 ns** | **180.81 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | .NET 8.0 | 3      | 179.07 ns | 30.083 ns | 1.649 ns | 177.41 ns | 180.71 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 3      | 176.64 ns | 77.669 ns | 4.257 ns | 172.89 ns | 181.27 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 3      |  59.25 ns |  2.212 ns | 0.121 ns |  59.17 ns |  59.39 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 3      |  58.74 ns |  3.614 ns | 0.198 ns |  58.61 ns |  58.97 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 3      |  56.18 ns |  7.038 ns | 0.386 ns |  55.95 ns |  56.63 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 3      | 170.17 ns | 12.116 ns | 0.664 ns | 169.70 ns | 170.93 ns | 0.0157 |     264 B |
| LogWithIfParams                            | .NET 9.0 | 3      | 170.34 ns | 25.584 ns | 1.402 ns | 169.00 ns | 171.80 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 3      | 173.00 ns | 27.634 ns | 1.515 ns | 171.32 ns | 174.26 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 3      |  59.42 ns |  3.944 ns | 0.216 ns |  59.27 ns |  59.67 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 3      |  58.42 ns |  6.596 ns | 0.362 ns |  58.20 ns |  58.84 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 3      |  57.06 ns |  0.643 ns | 0.035 ns |  57.03 ns |  57.10 ns |      - |         - |
