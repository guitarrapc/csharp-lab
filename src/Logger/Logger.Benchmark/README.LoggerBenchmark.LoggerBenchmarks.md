```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **59.70 ns** |   **1.976 ns** |  **0.108 ns** |  **59.61 ns** |  **59.82 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  61.99 ns |   3.036 ns |  0.166 ns |  61.85 ns |  62.18 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  65.27 ns |   0.327 ns |  0.018 ns |  65.25 ns |  65.28 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.87 ns |   0.194 ns |  0.011 ns |  19.86 ns |  19.88 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.87 ns |   1.920 ns |  0.105 ns |  19.79 ns |  19.99 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  20.01 ns |   0.739 ns |  0.041 ns |  19.96 ns |  20.04 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **188.12 ns** | **188.699 ns** | **10.343 ns** | **180.76 ns** | **199.95 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 177.70 ns |  10.236 ns |  0.561 ns | 177.18 ns | 178.30 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 198.86 ns |   9.494 ns |  0.520 ns | 198.49 ns | 199.46 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.12 ns |   1.743 ns |  0.096 ns |  59.04 ns |  59.23 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.53 ns |   1.220 ns |  0.067 ns |  58.49 ns |  58.61 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.48 ns |   1.157 ns |  0.063 ns |  57.42 ns |  57.55 ns |      - |         - |
