```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **59.94 ns** |  **2.317 ns** | **0.127 ns** |  **59.84 ns** |  **60.08 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.60 ns |  6.574 ns | 0.360 ns |  59.22 ns |  59.93 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  64.88 ns |  5.056 ns | 0.277 ns |  64.69 ns |  65.19 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.96 ns |  2.640 ns | 0.145 ns |  19.87 ns |  20.12 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.91 ns |  1.875 ns | 0.103 ns |  19.79 ns |  19.97 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.29 ns |  5.132 ns | 0.281 ns |  19.13 ns |  19.62 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **183.05 ns** | **43.542 ns** | **2.387 ns** | **181.34 ns** | **185.78 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 178.80 ns | 27.025 ns | 1.481 ns | 177.20 ns | 180.13 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 193.38 ns |  7.822 ns | 0.429 ns | 193.01 ns | 193.85 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.11 ns |  2.206 ns | 0.121 ns |  59.04 ns |  59.25 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.53 ns |  3.661 ns | 0.201 ns |  58.30 ns |  58.68 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.71 ns |  2.172 ns | 0.119 ns |  57.64 ns |  57.85 ns |      - |         - |
