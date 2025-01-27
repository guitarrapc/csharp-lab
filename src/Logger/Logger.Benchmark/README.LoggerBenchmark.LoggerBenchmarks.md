```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **57.24 ns** |  **5.188 ns** | **0.284 ns** |  **57.01 ns** |  **57.56 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | 1      |  57.65 ns | 11.179 ns | 0.613 ns |  56.96 ns |  58.13 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  62.38 ns |  5.064 ns | 0.278 ns |  62.22 ns |  62.70 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.89 ns |  0.187 ns | 0.010 ns |  19.88 ns |  19.90 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  20.06 ns |  1.753 ns | 0.096 ns |  19.95 ns |  20.12 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.88 ns |  9.829 ns | 0.539 ns |  19.26 ns |  20.20 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **172.22 ns** |  **4.433 ns** | **0.243 ns** | **171.95 ns** | **172.40 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | 3      | 168.24 ns |  9.797 ns | 0.537 ns | 167.68 ns | 168.75 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 187.92 ns | 26.724 ns | 1.465 ns | 186.73 ns | 189.56 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.44 ns |  1.349 ns | 0.074 ns |  59.39 ns |  59.53 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.18 ns |  0.667 ns | 0.037 ns |  58.15 ns |  58.22 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.12 ns |  0.105 ns | 0.006 ns |  57.11 ns |  57.12 ns |      - |         - |
