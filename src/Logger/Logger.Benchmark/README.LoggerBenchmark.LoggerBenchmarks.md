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
| **LogWithoutIfParams**                         | **1**      |  **61.15 ns** |  **2.347 ns** | **0.129 ns** |  **61.00 ns** |  **61.25 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.87 ns | 21.213 ns | 1.163 ns |  59.18 ns |  61.22 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  65.74 ns | 18.508 ns | 1.015 ns |  64.88 ns |  66.86 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.78 ns |  0.078 ns | 0.004 ns |  19.78 ns |  19.78 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.85 ns |  0.377 ns | 0.021 ns |  19.83 ns |  19.87 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.38 ns |  1.335 ns | 0.073 ns |  19.29 ns |  19.43 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **180.93 ns** |  **3.684 ns** | **0.202 ns** | **180.73 ns** | **181.14 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 194.23 ns |  8.282 ns | 0.454 ns | 193.70 ns | 194.52 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 197.73 ns | 11.367 ns | 0.623 ns | 197.02 ns | 198.15 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.35 ns |  0.605 ns | 0.033 ns |  59.32 ns |  59.38 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.50 ns |  1.627 ns | 0.089 ns |  58.44 ns |  58.60 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.92 ns | 19.146 ns | 1.049 ns |  57.14 ns |  59.12 ns |      - |         - |
