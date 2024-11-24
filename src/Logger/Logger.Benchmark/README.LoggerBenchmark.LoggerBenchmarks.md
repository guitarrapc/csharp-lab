```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **61.12 ns** |  **3.189 ns** | **0.175 ns** |  **60.94 ns** |  **61.29 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  60.77 ns | 26.377 ns | 1.446 ns |  59.63 ns |  62.40 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  67.07 ns | 39.445 ns | 2.162 ns |  65.79 ns |  69.56 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.82 ns |  0.096 ns | 0.005 ns |  19.81 ns |  19.82 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.89 ns |  3.129 ns | 0.172 ns |  19.79 ns |  20.09 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.22 ns |  1.664 ns | 0.091 ns |  19.13 ns |  19.31 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **181.58 ns** | **13.314 ns** | **0.730 ns** | **180.76 ns** | **182.15 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 180.91 ns | 32.988 ns | 1.808 ns | 179.80 ns | 183.00 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 200.29 ns | 11.578 ns | 0.635 ns | 199.62 ns | 200.88 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  58.97 ns |  0.640 ns | 0.035 ns |  58.94 ns |  59.01 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.29 ns |  0.164 ns | 0.009 ns |  58.28 ns |  58.30 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  59.84 ns |  0.122 ns | 0.007 ns |  59.83 ns |  59.84 ns |      - |         - |
