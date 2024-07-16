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
| **LogWithoutIfParams**                         | **1**      |  **61.17 ns** |  **7.995 ns** | **0.438 ns** |  **60.81 ns** |  **61.66 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.06 ns |  4.189 ns | 0.230 ns |  58.80 ns |  59.24 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  66.09 ns |  7.667 ns | 0.420 ns |  65.83 ns |  66.58 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.92 ns |  2.907 ns | 0.159 ns |  19.79 ns |  20.10 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.83 ns |  0.063 ns | 0.003 ns |  19.83 ns |  19.83 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.26 ns |  1.919 ns | 0.105 ns |  19.15 ns |  19.36 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **182.81 ns** | **44.903 ns** | **2.461 ns** | **180.08 ns** | **184.86 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 178.13 ns | 10.958 ns | 0.601 ns | 177.74 ns | 178.82 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 197.40 ns | 19.983 ns | 1.095 ns | 196.56 ns | 198.64 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.10 ns |  2.177 ns | 0.119 ns |  59.03 ns |  59.24 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.23 ns |  0.452 ns | 0.025 ns |  58.21 ns |  58.25 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  59.33 ns |  4.915 ns | 0.269 ns |  59.13 ns |  59.64 ns |      - |         - |
