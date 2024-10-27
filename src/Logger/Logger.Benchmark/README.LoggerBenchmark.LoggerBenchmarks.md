```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **60.22 ns** |  **1.345 ns** | **0.074 ns** |  **60.14 ns** |  **60.28 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  61.82 ns | 28.449 ns | 1.559 ns |  60.92 ns |  63.62 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  67.58 ns |  6.459 ns | 0.354 ns |  67.27 ns |  67.96 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.94 ns |  0.994 ns | 0.055 ns |  19.88 ns |  19.98 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.96 ns |  0.231 ns | 0.013 ns |  19.94 ns |  19.96 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.56 ns |  5.671 ns | 0.311 ns |  19.36 ns |  19.92 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **180.27 ns** |  **3.963 ns** | **0.217 ns** | **180.02 ns** | **180.42 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 181.64 ns | 63.106 ns | 3.459 ns | 179.37 ns | 185.62 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 205.42 ns | 10.516 ns | 0.576 ns | 204.97 ns | 206.07 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.49 ns |  3.643 ns | 0.200 ns |  59.30 ns |  59.70 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.38 ns |  0.771 ns | 0.042 ns |  58.33 ns |  58.41 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.11 ns |  0.720 ns | 0.039 ns |  57.08 ns |  57.15 ns |      - |         - |
