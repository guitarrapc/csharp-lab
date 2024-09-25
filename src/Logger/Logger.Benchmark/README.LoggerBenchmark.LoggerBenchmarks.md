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
| **LogWithoutIfParams**                         | **1**      |  **61.57 ns** |  **1.771 ns** | **0.097 ns** |  **61.48 ns** |  **61.67 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  65.12 ns | 39.189 ns | 2.148 ns |  63.56 ns |  67.57 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  66.05 ns |  2.939 ns | 0.161 ns |  65.93 ns |  66.23 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.92 ns |  0.569 ns | 0.031 ns |  19.89 ns |  19.95 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  20.08 ns |  0.791 ns | 0.043 ns |  20.04 ns |  20.12 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.27 ns |  0.902 ns | 0.049 ns |  19.23 ns |  19.32 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **214.05 ns** | **21.809 ns** | **1.195 ns** | **213.27 ns** | **215.43 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 181.52 ns | 12.053 ns | 0.661 ns | 181.12 ns | 182.28 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 203.30 ns | 30.586 ns | 1.677 ns | 201.38 ns | 204.50 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.49 ns |  0.696 ns | 0.038 ns |  59.45 ns |  59.53 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.77 ns |  4.380 ns | 0.240 ns |  58.62 ns |  59.05 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  58.10 ns |  2.189 ns | 0.120 ns |  57.97 ns |  58.21 ns |      - |         - |
