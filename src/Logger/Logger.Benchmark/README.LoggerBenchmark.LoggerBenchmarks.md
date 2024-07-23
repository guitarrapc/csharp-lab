```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **66.30 ns** | **11.254 ns** | **0.617 ns** |  **65.94 ns** |  **67.01 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.91 ns |  2.807 ns | 0.154 ns |  59.73 ns |  60.01 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  73.25 ns | 40.290 ns | 2.208 ns |  71.58 ns |  75.75 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.82 ns |  0.071 ns | 0.004 ns |  19.82 ns |  19.82 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.81 ns |  0.408 ns | 0.022 ns |  19.78 ns |  19.82 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  21.54 ns |  0.971 ns | 0.053 ns |  21.49 ns |  21.60 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **180.38 ns** |  **3.707 ns** | **0.203 ns** | **180.16 ns** | **180.56 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 178.36 ns |  2.485 ns | 0.136 ns | 178.22 ns | 178.50 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 206.45 ns | 74.966 ns | 4.109 ns | 202.85 ns | 210.93 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.35 ns |  1.304 ns | 0.071 ns |  59.30 ns |  59.43 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  60.45 ns |  0.375 ns | 0.021 ns |  60.42 ns |  60.46 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.84 ns |  0.444 ns | 0.024 ns |  57.82 ns |  57.87 ns |      - |         - |
