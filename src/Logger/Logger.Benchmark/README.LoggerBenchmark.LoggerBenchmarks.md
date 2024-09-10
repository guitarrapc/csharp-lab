```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **62.02 ns** |  **3.941 ns** | **0.216 ns** |  **61.79 ns** |  **62.22 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  61.58 ns | 21.795 ns | 1.195 ns |  60.78 ns |  62.95 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  65.88 ns |  9.329 ns | 0.511 ns |  65.54 ns |  66.47 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.83 ns |  0.356 ns | 0.020 ns |  19.82 ns |  19.85 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  19.82 ns |  0.862 ns | 0.047 ns |  19.78 ns |  19.87 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.62 ns |  2.443 ns | 0.134 ns |  19.49 ns |  19.76 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **182.36 ns** |  **8.904 ns** | **0.488 ns** | **181.91 ns** | **182.87 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 179.33 ns |  6.440 ns | 0.353 ns | 179.11 ns | 179.74 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 204.25 ns |  7.436 ns | 0.408 ns | 203.78 ns | 204.55 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  58.77 ns |  2.245 ns | 0.123 ns |  58.67 ns |  58.91 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.36 ns |  0.633 ns | 0.035 ns |  58.33 ns |  58.40 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.93 ns |  1.523 ns | 0.083 ns |  57.85 ns |  58.01 ns |      - |         - |
