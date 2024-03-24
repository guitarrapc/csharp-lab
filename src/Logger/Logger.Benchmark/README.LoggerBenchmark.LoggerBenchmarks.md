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
| **LogWithoutIfParams**                         | **1**      |  **60.60 ns** |  **4.054 ns** | **0.222 ns** |  **60.34 ns** |  **60.75 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  60.28 ns |  5.602 ns | 0.307 ns |  59.94 ns |  60.53 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  68.09 ns | 54.222 ns | 2.972 ns |  65.34 ns |  71.24 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.99 ns |  2.178 ns | 0.119 ns |  19.85 ns |  20.08 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.96 ns |  0.733 ns | 0.040 ns |  19.93 ns |  20.00 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.31 ns |  4.990 ns | 0.274 ns |  19.14 ns |  19.63 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **180.40 ns** | **44.676 ns** | **2.449 ns** | **178.65 ns** | **183.20 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 176.93 ns |  3.226 ns | 0.177 ns | 176.77 ns | 177.12 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 195.99 ns | 85.372 ns | 4.680 ns | 193.22 ns | 201.39 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.39 ns |  6.006 ns | 0.329 ns |  59.18 ns |  59.77 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.30 ns |  0.595 ns | 0.033 ns |  58.28 ns |  58.34 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.82 ns |  2.228 ns | 0.122 ns |  57.70 ns |  57.94 ns |      - |         - |
