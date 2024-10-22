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
| **LogWithoutIfParams**                         | **1**      |  **60.00 ns** |  **3.234 ns** | **0.177 ns** |  **59.85 ns** |  **60.19 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  60.85 ns | 31.435 ns | 1.723 ns |  59.14 ns |  62.58 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  67.86 ns |  1.459 ns | 0.080 ns |  67.79 ns |  67.95 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.91 ns |  0.178 ns | 0.010 ns |  19.90 ns |  19.92 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.80 ns |  0.122 ns | 0.007 ns |  19.80 ns |  19.81 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.43 ns |  0.150 ns | 0.008 ns |  19.42 ns |  19.44 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **180.58 ns** |  **7.577 ns** | **0.415 ns** | **180.22 ns** | **181.03 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 178.64 ns | 22.046 ns | 1.208 ns | 177.89 ns | 180.04 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 196.75 ns |  3.130 ns | 0.172 ns | 196.56 ns | 196.87 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.06 ns |  1.754 ns | 0.096 ns |  59.00 ns |  59.17 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.23 ns |  0.557 ns | 0.031 ns |  58.20 ns |  58.26 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  60.02 ns |  5.310 ns | 0.291 ns |  59.83 ns |  60.35 ns |      - |         - |
