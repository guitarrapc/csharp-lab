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
| **LogWithoutIfParams**                         | **1**      |  **63.64 ns** | **20.900 ns** | **1.146 ns** |  **62.94 ns** |  **64.96 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  61.00 ns | 19.101 ns | 1.047 ns |  60.34 ns |  62.21 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  68.11 ns | 17.210 ns | 0.943 ns |  67.51 ns |  69.20 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.87 ns |  0.291 ns | 0.016 ns |  19.86 ns |  19.89 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  20.07 ns |  5.979 ns | 0.328 ns |  19.83 ns |  20.44 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.22 ns |  0.450 ns | 0.025 ns |  19.20 ns |  19.25 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **187.60 ns** |  **4.235 ns** | **0.232 ns** | **187.36 ns** | **187.82 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 183.87 ns | 10.333 ns | 0.566 ns | 183.53 ns | 184.53 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 200.76 ns |  5.939 ns | 0.326 ns | 200.48 ns | 201.11 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  58.97 ns |  0.564 ns | 0.031 ns |  58.95 ns |  59.00 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.94 ns | 23.170 ns | 1.270 ns |  58.20 ns |  60.41 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.65 ns |  0.874 ns | 0.048 ns |  57.60 ns |  57.69 ns |      - |         - |
