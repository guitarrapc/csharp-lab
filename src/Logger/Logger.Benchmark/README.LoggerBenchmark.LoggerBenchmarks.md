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
| **LogWithoutIfParams**                         | **1**      |  **60.17 ns** |  **4.087 ns** | **0.224 ns** |  **59.94 ns** |  **60.39 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  61.11 ns |  1.026 ns | 0.056 ns |  61.05 ns |  61.15 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  67.21 ns |  2.966 ns | 0.163 ns |  67.11 ns |  67.39 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.96 ns |  2.252 ns | 0.123 ns |  19.86 ns |  20.10 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.96 ns |  0.158 ns | 0.009 ns |  19.96 ns |  19.97 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.14 ns |  0.153 ns | 0.008 ns |  19.13 ns |  19.14 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **179.71 ns** |  **3.925 ns** | **0.215 ns** | **179.47 ns** | **179.88 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 178.83 ns | 26.630 ns | 1.460 ns | 177.84 ns | 180.50 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 207.56 ns | 97.412 ns | 5.339 ns | 204.30 ns | 213.72 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  58.91 ns |  0.190 ns | 0.010 ns |  58.90 ns |  58.92 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.38 ns |  1.087 ns | 0.060 ns |  58.34 ns |  58.45 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.28 ns |  8.601 ns | 0.471 ns |  56.99 ns |  57.82 ns |      - |         - |
