```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean        | Error        | StdDev     | Min         | Max         | Gen0   | Allocated |
|------------------------------------------- |------- |------------:|-------------:|-----------:|------------:|------------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |    **67.78 ns** |     **8.784 ns** |   **0.481 ns** |    **67.23 ns** |    **68.14 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    68.16 ns |    12.711 ns |   0.697 ns |    67.41 ns |    68.79 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    76.11 ns |    11.240 ns |   0.616 ns |    75.55 ns |    76.77 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    21.31 ns |     1.041 ns |   0.057 ns |    21.24 ns |    21.34 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    21.25 ns |     2.351 ns |   0.129 ns |    21.15 ns |    21.40 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    20.89 ns |     5.208 ns |   0.285 ns |    20.58 ns |    21.14 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **667.16 ns** |    **41.013 ns** |   **2.248 ns** |   **665.00 ns** |   **669.49 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   685.87 ns |   100.187 ns |   5.492 ns |   679.60 ns |   689.84 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   737.37 ns |    42.402 ns |   2.324 ns |   734.69 ns |   738.82 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   213.21 ns |     6.197 ns |   0.340 ns |   212.96 ns |   213.60 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   210.46 ns |     3.351 ns |   0.184 ns |   210.27 ns |   210.64 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   205.75 ns |    29.971 ns |   1.643 ns |   204.46 ns |   207.60 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,678.32 ns** | **2,655.790 ns** | **145.573 ns** | **6,576.34 ns** | **6,845.04 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 7,129.60 ns |   835.500 ns |  45.797 ns | 7,102.55 ns | 7,182.47 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 7,384.35 ns | 1,165.239 ns |  63.871 ns | 7,338.51 ns | 7,457.30 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 2,141.53 ns |    12.753 ns |   0.699 ns | 2,140.90 ns | 2,142.29 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 2,153.00 ns |    94.814 ns |   5.197 ns | 2,149.05 ns | 2,158.88 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 2,079.16 ns |    98.427 ns |   5.395 ns | 2,074.95 ns | 2,085.24 ns |      - |         - |
