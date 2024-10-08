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
| **LogWithoutIfParams**                         | **1**      |  **61.21 ns** |  **1.556 ns** | **0.085 ns** |  **61.12 ns** |  **61.27 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  61.86 ns |  5.048 ns | 0.277 ns |  61.64 ns |  62.17 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  67.72 ns |  7.173 ns | 0.393 ns |  67.45 ns |  68.17 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  20.17 ns |  6.711 ns | 0.368 ns |  19.90 ns |  20.59 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  20.15 ns |  5.690 ns | 0.312 ns |  19.90 ns |  20.50 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.25 ns |  0.037 ns | 0.002 ns |  19.24 ns |  19.25 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **186.14 ns** | **31.567 ns** | **1.730 ns** | **184.16 ns** | **187.36 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 181.53 ns | 12.369 ns | 0.678 ns | 180.85 ns | 182.20 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 198.19 ns |  7.009 ns | 0.384 ns | 197.82 ns | 198.59 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.35 ns |  2.362 ns | 0.129 ns |  59.26 ns |  59.50 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.75 ns |  1.307 ns | 0.072 ns |  58.67 ns |  58.79 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.47 ns |  4.503 ns | 0.247 ns |  57.27 ns |  57.75 ns |      - |         - |
