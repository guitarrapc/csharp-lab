```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |  **65.44 ns** |   **3.191 ns** | **0.175 ns** |  **65.29 ns** |  **65.63 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |  59.36 ns |   2.866 ns | 0.157 ns |  59.18 ns |  59.45 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |  70.14 ns |   2.111 ns | 0.116 ns |  70.02 ns |  70.25 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |  19.79 ns |   0.235 ns | 0.013 ns |  19.77 ns |  19.80 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |  20.94 ns |   0.810 ns | 0.044 ns |  20.90 ns |  20.99 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |  19.17 ns |   1.498 ns | 0.082 ns |  19.12 ns |  19.26 ns |      - |         - |
| **LogWithoutIfParams**                         | **3**      | **180.61 ns** |   **8.391 ns** | **0.460 ns** | **180.20 ns** | **181.11 ns** | **0.0031** |     **264 B** |
| LogWithIfParams                            | 3      | 179.29 ns |   7.517 ns | 0.412 ns | 178.85 ns | 179.67 ns | 0.0031 |     264 B |
| LogAdapterWithoutIfParams                  | 3      | 216.89 ns | 127.724 ns | 7.001 ns | 212.42 ns | 224.95 ns | 0.0031 |     264 B |
| LogDefineWithoutIfParams                   | 3      |  59.18 ns |   6.060 ns | 0.332 ns |  58.96 ns |  59.57 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 3      |  58.27 ns |   1.922 ns | 0.105 ns |  58.19 ns |  58.39 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 3      |  57.66 ns |  18.963 ns | 1.039 ns |  56.96 ns |  58.85 ns |      - |         - |
