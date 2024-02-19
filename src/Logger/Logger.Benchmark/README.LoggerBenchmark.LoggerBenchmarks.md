```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean        | Error        | StdDev     | Min         | Max         | Gen0   | Allocated |
|------------------------------------------- |------- |------------:|-------------:|-----------:|------------:|------------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |    **60.86 ns** |     **3.907 ns** |   **0.214 ns** |    **60.73 ns** |    **61.11 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    59.97 ns |     3.142 ns |   0.172 ns |    59.78 ns |    60.12 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    65.02 ns |     3.745 ns |   0.205 ns |    64.81 ns |    65.22 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    19.88 ns |     4.090 ns |   0.224 ns |    19.75 ns |    20.14 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    19.80 ns |     0.704 ns |   0.039 ns |    19.77 ns |    19.84 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.14 ns |     0.422 ns |   0.023 ns |    19.12 ns |    19.17 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **633.65 ns** |   **176.972 ns** |   **9.700 ns** |   **626.72 ns** |   **644.73 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   600.63 ns |    41.515 ns |   2.276 ns |   598.00 ns |   601.95 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   693.89 ns |    17.729 ns |   0.972 ns |   692.79 ns |   694.63 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   198.58 ns |    21.838 ns |   1.197 ns |   197.86 ns |   199.96 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   197.08 ns |    11.407 ns |   0.625 ns |   196.69 ns |   197.81 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   192.95 ns |    10.236 ns |   0.561 ns |   192.53 ns |   193.58 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,315.83 ns** |   **110.633 ns** |   **6.064 ns** | **6,309.43 ns** | **6,321.50 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 6,120.56 ns | 2,099.958 ns | 115.106 ns | 6,041.63 ns | 6,252.63 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,549.89 ns |   394.776 ns |  21.639 ns | 6,526.45 ns | 6,569.11 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 1,992.15 ns |   137.153 ns |   7.518 ns | 1,983.47 ns | 1,996.52 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 1,981.43 ns |    55.868 ns |   3.062 ns | 1,979.08 ns | 1,984.89 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,986.16 ns | 1,917.608 ns | 105.111 ns | 1,925.36 ns | 2,107.53 ns |      - |         - |
