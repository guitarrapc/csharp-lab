```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **60.44 ns** |  **4.584 ns** | **0.251 ns** |  **60.18 ns** |  **60.68 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.65 ns |  5.238 ns | 0.287 ns |  59.40 ns |  59.97 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  65.33 ns |  1.624 ns | 0.089 ns |  65.23 ns |  65.41 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  20.00 ns |  3.142 ns | 0.172 ns |  19.84 ns |  20.18 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  20.09 ns |  5.390 ns | 0.295 ns |  19.90 ns |  20.43 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.37 ns |  0.139 ns | 0.008 ns |  19.36 ns |  19.38 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **187.97 ns** |  **2.255 ns** | **0.124 ns** | **187.88 ns** | **188.11 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 178.01 ns | 12.019 ns | 0.659 ns | 177.25 ns | 178.40 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 195.47 ns |  7.420 ns | 0.407 ns | 195.02 ns | 195.81 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.00 ns |  1.097 ns | 0.060 ns |  58.96 ns |  59.07 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.42 ns |  1.600 ns | 0.088 ns |  58.34 ns |  58.52 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.78 ns |  2.927 ns | 0.160 ns |  57.59 ns |  57.90 ns |      - |         - |
