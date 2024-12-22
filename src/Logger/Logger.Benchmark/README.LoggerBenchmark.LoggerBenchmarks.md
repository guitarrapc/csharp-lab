```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **58.12 ns** |  **1.175 ns** | **0.064 ns** |  **58.08 ns** |  **58.20 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  58.13 ns |  1.196 ns | 0.066 ns |  58.09 ns |  58.21 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  64.88 ns |  2.956 ns | 0.162 ns |  64.69 ns |  64.97 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  20.01 ns |  3.045 ns | 0.167 ns |  19.83 ns |  20.17 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.99 ns |  2.239 ns | 0.123 ns |  19.91 ns |  20.13 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.34 ns |  2.482 ns | 0.136 ns |  19.22 ns |  19.49 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **177.57 ns** | **28.155 ns** | **1.543 ns** | **176.52 ns** | **179.34 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 174.42 ns |  9.727 ns | 0.533 ns | 173.81 ns | 174.81 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 192.16 ns | 57.878 ns | 3.172 ns | 190.14 ns | 195.82 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  58.84 ns |  3.783 ns | 0.207 ns |  58.71 ns |  59.08 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.87 ns |  0.753 ns | 0.041 ns |  58.83 ns |  58.91 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  56.45 ns |  1.881 ns | 0.103 ns |  56.33 ns |  56.53 ns |      - |         - |
