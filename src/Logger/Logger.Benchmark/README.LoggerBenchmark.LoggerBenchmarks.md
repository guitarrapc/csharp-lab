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
| **LogWithoutIfParams**                         | **1**      |  **61.66 ns** |  **6.900 ns** | **0.378 ns** |  **61.23 ns** |  **61.93 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.65 ns |  1.812 ns | 0.099 ns |  59.54 ns |  59.74 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  65.52 ns |  4.662 ns | 0.256 ns |  65.28 ns |  65.79 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  31.80 ns | 26.262 ns | 1.440 ns |  30.15 ns |  32.80 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.90 ns |  0.784 ns | 0.043 ns |  19.85 ns |  19.93 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.27 ns |  1.507 ns | 0.083 ns |  19.17 ns |  19.32 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **180.52 ns** | **15.838 ns** | **0.868 ns** | **179.96 ns** | **181.52 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 178.39 ns |  7.146 ns | 0.392 ns | 177.94 ns | 178.67 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 201.28 ns | 34.619 ns | 1.898 ns | 199.67 ns | 203.37 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.07 ns |  3.017 ns | 0.165 ns |  58.97 ns |  59.26 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.22 ns |  1.123 ns | 0.062 ns |  58.17 ns |  58.29 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.73 ns | 22.822 ns | 1.251 ns |  56.99 ns |  59.17 ns |      - |         - |
