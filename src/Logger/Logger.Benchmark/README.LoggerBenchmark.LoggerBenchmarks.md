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
| **LogWithoutIfParams**                         | **1**      |  **60.62 ns** |  **2.989 ns** | **0.164 ns** |  **60.49 ns** |  **60.81 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  63.08 ns |  5.687 ns | 0.312 ns |  62.84 ns |  63.43 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  65.86 ns |  3.926 ns | 0.215 ns |  65.72 ns |  66.11 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.89 ns |  1.202 ns | 0.066 ns |  19.81 ns |  19.93 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.72 ns |  0.622 ns | 0.034 ns |  19.70 ns |  19.76 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.20 ns |  0.929 ns | 0.051 ns |  19.17 ns |  19.26 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **178.42 ns** |  **5.333 ns** | **0.292 ns** | **178.09 ns** | **178.65 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 181.94 ns | 32.565 ns | 1.785 ns | 179.90 ns | 183.23 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 196.12 ns | 15.615 ns | 0.856 ns | 195.22 ns | 196.93 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.10 ns |  1.936 ns | 0.106 ns |  58.98 ns |  59.18 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.22 ns |  0.060 ns | 0.003 ns |  58.22 ns |  58.23 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.44 ns |  0.270 ns | 0.015 ns |  57.43 ns |  57.45 ns |      - |         - |
