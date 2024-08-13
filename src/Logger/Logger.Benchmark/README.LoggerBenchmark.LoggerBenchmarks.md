```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **61.73 ns** |  **5.084 ns** | **0.279 ns** |  **61.46 ns** |  **62.01 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  66.62 ns | 19.095 ns | 1.047 ns |  65.97 ns |  67.83 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  67.68 ns |  8.578 ns | 0.470 ns |  67.30 ns |  68.21 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  22.90 ns |  1.388 ns | 0.076 ns |  22.83 ns |  22.98 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.80 ns |  0.567 ns | 0.031 ns |  19.76 ns |  19.82 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.12 ns |  0.029 ns | 0.002 ns |  19.12 ns |  19.12 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **182.75 ns** |  **6.188 ns** | **0.339 ns** | **182.37 ns** | **183.02 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 178.78 ns |  3.750 ns | 0.206 ns | 178.61 ns | 179.01 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 196.87 ns |  8.331 ns | 0.457 ns | 196.35 ns | 197.14 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  58.97 ns |  0.710 ns | 0.039 ns |  58.92 ns |  58.99 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.55 ns |  2.789 ns | 0.153 ns |  58.43 ns |  58.72 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.52 ns |  0.662 ns | 0.036 ns |  57.48 ns |  57.55 ns |      - |         - |
