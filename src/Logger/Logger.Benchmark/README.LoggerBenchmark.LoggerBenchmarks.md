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
| **LogWithoutIfParams**                         | **1**      |  **61.98 ns** |  **5.044 ns** | **0.276 ns** |  **61.78 ns** |  **62.29 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  61.81 ns | 20.979 ns | 1.150 ns |  60.57 ns |  62.84 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  66.09 ns | 17.912 ns | 0.982 ns |  65.30 ns |  67.19 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.90 ns |  0.848 ns | 0.046 ns |  19.86 ns |  19.95 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.87 ns |  1.151 ns | 0.063 ns |  19.83 ns |  19.95 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.35 ns |  1.970 ns | 0.108 ns |  19.27 ns |  19.47 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **185.01 ns** |  **1.950 ns** | **0.107 ns** | **184.90 ns** | **185.12 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 179.59 ns |  6.377 ns | 0.350 ns | 179.25 ns | 179.95 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 198.18 ns | 17.719 ns | 0.971 ns | 197.33 ns | 199.24 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  58.93 ns |  0.770 ns | 0.042 ns |  58.90 ns |  58.98 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.20 ns |  0.273 ns | 0.015 ns |  58.19 ns |  58.21 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.03 ns |  2.231 ns | 0.122 ns |  56.91 ns |  57.15 ns |      - |         - |
