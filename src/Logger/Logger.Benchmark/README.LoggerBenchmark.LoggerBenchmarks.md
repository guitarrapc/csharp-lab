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
| **LogWithoutIfParams**                         | **1**      |  **64.63 ns** |  **5.050 ns** | **0.277 ns** |  **64.35 ns** |  **64.90 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.52 ns |  2.069 ns | 0.113 ns |  59.45 ns |  59.65 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  65.71 ns |  3.720 ns | 0.204 ns |  65.49 ns |  65.88 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.81 ns |  0.058 ns | 0.003 ns |  19.80 ns |  19.81 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.80 ns |  0.151 ns | 0.008 ns |  19.79 ns |  19.81 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.17 ns |  1.371 ns | 0.075 ns |  19.13 ns |  19.26 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **178.71 ns** |  **2.946 ns** | **0.161 ns** | **178.53 ns** | **178.81 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 181.36 ns | 84.321 ns | 4.622 ns | 177.77 ns | 186.58 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 196.18 ns |  4.465 ns | 0.245 ns | 196.01 ns | 196.47 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.09 ns |  0.502 ns | 0.028 ns |  59.08 ns |  59.13 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.71 ns |  9.213 ns | 0.505 ns |  58.28 ns |  59.26 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.39 ns |  9.074 ns | 0.497 ns |  57.00 ns |  57.95 ns |      - |         - |
