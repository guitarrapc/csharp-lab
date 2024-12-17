```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **58.16 ns** |  **0.775 ns** | **0.042 ns** |  **58.12 ns** |  **58.20 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  60.96 ns | 29.633 ns | 1.624 ns |  59.97 ns |  62.83 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  65.25 ns | 22.369 ns | 1.226 ns |  64.47 ns |  66.66 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.80 ns |  0.215 ns | 0.012 ns |  19.78 ns |  19.81 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.94 ns |  1.615 ns | 0.089 ns |  19.87 ns |  20.04 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.25 ns |  1.112 ns | 0.061 ns |  19.21 ns |  19.32 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **174.22 ns** |  **3.532 ns** | **0.194 ns** | **174.02 ns** | **174.41 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 175.66 ns | 11.369 ns | 0.623 ns | 175.14 ns | 176.35 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 192.60 ns |  4.080 ns | 0.224 ns | 192.40 ns | 192.84 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  58.72 ns |  0.413 ns | 0.023 ns |  58.69 ns |  58.73 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.01 ns |  0.351 ns | 0.019 ns |  58.00 ns |  58.03 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.43 ns |  1.722 ns | 0.094 ns |  57.33 ns |  57.51 ns |      - |         - |
