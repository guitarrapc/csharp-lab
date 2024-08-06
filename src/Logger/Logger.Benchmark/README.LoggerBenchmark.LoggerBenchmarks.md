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
| **LogWithoutIfParams**                         | **1**      |  **63.03 ns** |  **6.498 ns** | **0.356 ns** |  **62.71 ns** |  **63.42 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.26 ns |  1.410 ns | 0.077 ns |  59.20 ns |  59.35 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  70.05 ns | 30.140 ns | 1.652 ns |  68.92 ns |  71.95 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  20.37 ns | 15.791 ns | 0.866 ns |  19.83 ns |  21.36 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.73 ns |  0.668 ns | 0.037 ns |  19.69 ns |  19.77 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.46 ns |  0.494 ns | 0.027 ns |  19.44 ns |  19.49 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **180.88 ns** | **13.231 ns** | **0.725 ns** | **180.40 ns** | **181.72 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 180.65 ns | 13.187 ns | 0.723 ns | 179.86 ns | 181.29 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 197.48 ns | 25.396 ns | 1.392 ns | 196.60 ns | 199.09 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.05 ns |  0.816 ns | 0.045 ns |  59.00 ns |  59.09 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.31 ns |  0.316 ns | 0.017 ns |  58.30 ns |  58.33 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.81 ns |  5.879 ns | 0.322 ns |  57.61 ns |  58.18 ns |      - |         - |
