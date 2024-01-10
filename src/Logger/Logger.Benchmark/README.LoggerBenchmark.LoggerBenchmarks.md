```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean        | Error        | StdDev     | Min         | Max         | Gen0   | Allocated |
|------------------------------------------- |------- |------------:|-------------:|-----------:|------------:|------------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |    **60.60 ns** |     **1.187 ns** |   **0.065 ns** |    **60.52 ns** |    **60.64 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    60.78 ns |     0.808 ns |   0.044 ns |    60.74 ns |    60.82 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    65.79 ns |     4.081 ns |   0.224 ns |    65.62 ns |    66.05 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    20.04 ns |     3.750 ns |   0.206 ns |    19.81 ns |    20.20 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    20.58 ns |    15.216 ns |   0.834 ns |    19.93 ns |    21.52 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.21 ns |     1.230 ns |   0.067 ns |    19.17 ns |    19.29 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **613.64 ns** |    **17.963 ns** |   **0.985 ns** |   **612.79 ns** |   **614.72 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   602.20 ns |    19.584 ns |   1.073 ns |   601.17 ns |   603.32 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   662.80 ns |    64.512 ns |   3.536 ns |   658.72 ns |   665.02 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   198.92 ns |    14.428 ns |   0.791 ns |   198.34 ns |   199.82 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   197.77 ns |     8.088 ns |   0.443 ns |   197.27 ns |   198.13 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   193.48 ns |    50.233 ns |   2.753 ns |   191.52 ns |   196.63 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,141.84 ns** | **4,431.820 ns** | **242.923 ns** | **5,988.38 ns** | **6,421.92 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 6,421.51 ns | 1,719.767 ns |  94.266 ns | 6,362.14 ns | 6,530.21 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,615.16 ns | 1,931.651 ns | 105.880 ns | 6,536.13 ns | 6,735.46 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 1,993.86 ns |    93.676 ns |   5.135 ns | 1,987.93 ns | 1,996.95 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 1,982.87 ns |    13.427 ns |   0.736 ns | 1,982.04 ns | 1,983.45 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,940.39 ns |   519.032 ns |  28.450 ns | 1,919.87 ns | 1,972.87 ns |      - |         - |
