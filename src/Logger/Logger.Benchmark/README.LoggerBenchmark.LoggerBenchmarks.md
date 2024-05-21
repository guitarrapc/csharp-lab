```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **61.65 ns** |  **1.525 ns** | **0.084 ns** |  **61.56 ns** |  **61.72 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  60.35 ns |  9.180 ns | 0.503 ns |  60.00 ns |  60.93 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  66.31 ns |  7.315 ns | 0.401 ns |  66.04 ns |  66.77 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.83 ns |  0.613 ns | 0.034 ns |  19.80 ns |  19.86 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  20.09 ns |  4.950 ns | 0.271 ns |  19.90 ns |  20.40 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.24 ns |  0.541 ns | 0.030 ns |  19.22 ns |  19.27 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **191.31 ns** | **45.135 ns** | **2.474 ns** | **189.69 ns** | **194.16 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 180.51 ns | 26.794 ns | 1.469 ns | 178.87 ns | 181.71 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 202.77 ns | 49.477 ns | 2.712 ns | 199.65 ns | 204.56 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  60.89 ns | 41.325 ns | 2.265 ns |  59.03 ns |  63.41 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.72 ns |  2.861 ns | 0.157 ns |  58.54 ns |  58.82 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.84 ns |  1.964 ns | 0.108 ns |  57.73 ns |  57.95 ns |      - |         - |
