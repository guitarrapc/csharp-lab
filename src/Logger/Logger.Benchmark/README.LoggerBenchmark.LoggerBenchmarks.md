```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean        | Error        | StdDev     | Min         | Max         | Gen0   | Allocated |
|------------------------------------------- |------- |------------:|-------------:|-----------:|------------:|------------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |    **60.98 ns** |     **4.075 ns** |   **0.223 ns** |    **60.75 ns** |    **61.19 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    60.95 ns |     2.078 ns |   0.114 ns |    60.82 ns |    61.02 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    66.60 ns |    21.938 ns |   1.202 ns |    65.80 ns |    67.99 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    20.10 ns |     7.753 ns |   0.425 ns |    19.81 ns |    20.58 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    19.86 ns |     0.919 ns |   0.050 ns |    19.83 ns |    19.92 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.14 ns |     0.380 ns |   0.021 ns |    19.12 ns |    19.16 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **610.87 ns** |    **37.597 ns** |   **2.061 ns** |   **609.20 ns** |   **613.17 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   601.78 ns |    20.634 ns |   1.131 ns |   600.66 ns |   602.92 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   658.51 ns |    17.151 ns |   0.940 ns |   657.62 ns |   659.50 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   199.14 ns |     1.020 ns |   0.056 ns |   199.08 ns |   199.19 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   198.15 ns |    39.556 ns |   2.168 ns |   196.88 ns |   200.65 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   191.81 ns |     6.812 ns |   0.373 ns |   191.46 ns |   192.21 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,204.85 ns** | **3,237.797 ns** | **177.475 ns** | **6,096.55 ns** | **6,409.67 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 5,944.35 ns |   425.899 ns |  23.345 ns | 5,929.53 ns | 5,971.26 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,595.73 ns |   257.707 ns |  14.126 ns | 6,583.41 ns | 6,611.15 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 1,998.33 ns |    28.838 ns |   1.581 ns | 1,997.15 ns | 2,000.12 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 1,986.21 ns |    58.914 ns |   3.229 ns | 1,983.52 ns | 1,989.79 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,926.93 ns |    42.643 ns |   2.337 ns | 1,924.67 ns | 1,929.34 ns |      - |         - |
