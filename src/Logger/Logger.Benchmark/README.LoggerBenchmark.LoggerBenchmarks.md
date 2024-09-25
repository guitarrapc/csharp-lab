```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **62.60 ns** |  **6.857 ns** | **0.376 ns** |  **62.22 ns** |  **62.98 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  60.33 ns |  3.885 ns | 0.213 ns |  60.12 ns |  60.55 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  68.78 ns |  2.465 ns | 0.135 ns |  68.66 ns |  68.93 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.95 ns |  1.803 ns | 0.099 ns |  19.88 ns |  20.06 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  20.03 ns |  3.506 ns | 0.192 ns |  19.90 ns |  20.25 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.26 ns |  0.120 ns | 0.007 ns |  19.25 ns |  19.26 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **185.19 ns** | **26.330 ns** | **1.443 ns** | **183.56 ns** | **186.31 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 181.64 ns |  8.792 ns | 0.482 ns | 181.33 ns | 182.19 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 199.96 ns |  1.327 ns | 0.073 ns | 199.89 ns | 200.03 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.68 ns |  0.380 ns | 0.021 ns |  59.66 ns |  59.70 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  59.21 ns | 17.918 ns | 0.982 ns |  58.50 ns |  60.33 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  58.37 ns |  0.203 ns | 0.011 ns |  58.36 ns |  58.38 ns |      - |         - |
