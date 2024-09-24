```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **62.89 ns** | **10.048 ns** | **0.551 ns** |  **62.31 ns** |  **63.40 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  60.16 ns |  6.148 ns | 0.337 ns |  59.86 ns |  60.52 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  71.43 ns | 21.481 ns | 1.177 ns |  70.70 ns |  72.79 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  20.05 ns |  1.763 ns | 0.097 ns |  19.94 ns |  20.13 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.93 ns |  0.786 ns | 0.043 ns |  19.89 ns |  19.97 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.26 ns |  0.552 ns | 0.030 ns |  19.24 ns |  19.30 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **182.08 ns** |  **1.688 ns** | **0.093 ns** | **181.99 ns** | **182.17 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 182.47 ns | 34.443 ns | 1.888 ns | 181.36 ns | 184.65 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 200.87 ns | 54.395 ns | 2.982 ns | 199.13 ns | 204.32 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.31 ns |  2.867 ns | 0.157 ns |  59.17 ns |  59.48 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.54 ns |  0.176 ns | 0.010 ns |  58.53 ns |  58.55 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  60.23 ns |  2.863 ns | 0.157 ns |  60.13 ns |  60.41 ns |      - |         - |
