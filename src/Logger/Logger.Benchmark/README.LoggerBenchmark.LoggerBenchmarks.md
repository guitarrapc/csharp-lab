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
| **LogWithoutIfParams**                         | **1**      |  **61.31 ns** |  **2.218 ns** | **0.122 ns** |  **61.17 ns** |  **61.40 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.89 ns |  9.160 ns | 0.502 ns |  59.44 ns |  60.44 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  70.42 ns |  5.049 ns | 0.277 ns |  70.10 ns |  70.62 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.85 ns |  2.289 ns | 0.125 ns |  19.77 ns |  20.00 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  20.02 ns |  3.421 ns | 0.188 ns |  19.81 ns |  20.16 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.66 ns |  0.117 ns | 0.006 ns |  19.65 ns |  19.66 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **182.40 ns** | **25.340 ns** | **1.389 ns** | **180.98 ns** | **183.75 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 178.98 ns | 17.058 ns | 0.935 ns | 177.94 ns | 179.74 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 199.08 ns |  3.140 ns | 0.172 ns | 198.95 ns | 199.28 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.32 ns |  0.555 ns | 0.030 ns |  59.30 ns |  59.35 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.40 ns |  4.972 ns | 0.273 ns |  58.22 ns |  58.72 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.83 ns |  2.297 ns | 0.126 ns |  57.74 ns |  57.98 ns |      - |         - |
