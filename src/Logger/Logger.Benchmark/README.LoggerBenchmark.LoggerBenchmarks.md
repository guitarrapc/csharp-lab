```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------------------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |    **61.98 ns** |   **2.093 ns** | **0.115 ns** |    **61.91 ns** |    **62.11 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    59.58 ns |   3.388 ns | 0.186 ns |    59.46 ns |    59.79 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    65.62 ns |  20.085 ns | 1.101 ns |    64.98 ns |    66.90 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    19.87 ns |   0.152 ns | 0.008 ns |    19.86 ns |    19.88 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    19.80 ns |   0.290 ns | 0.016 ns |    19.79 ns |    19.82 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.19 ns |   0.126 ns | 0.007 ns |    19.18 ns |    19.20 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **607.03 ns** |  **14.864 ns** | **0.815 ns** |   **606.49 ns** |   **607.97 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   599.31 ns |  13.532 ns | 0.742 ns |   598.48 ns |   599.90 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   660.87 ns |   2.912 ns | 0.160 ns |   660.77 ns |   661.06 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   198.92 ns |   2.319 ns | 0.127 ns |   198.78 ns |   199.00 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   197.16 ns |   2.530 ns | 0.139 ns |   197.03 ns |   197.31 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   194.59 ns |  34.277 ns | 1.879 ns |   192.50 ns |   196.13 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,048.20 ns** | **126.582 ns** | **6.938 ns** | **6,041.22 ns** | **6,055.10 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 6,003.96 ns | 127.856 ns | 7.008 ns | 5,996.01 ns | 6,009.24 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,596.95 ns |  61.334 ns | 3.362 ns | 6,593.08 ns | 6,599.11 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 1,993.27 ns | 113.631 ns | 6.228 ns | 1,986.27 ns | 1,998.19 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 1,987.80 ns |  43.264 ns | 2.371 ns | 1,986.04 ns | 1,990.50 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,923.90 ns |  54.986 ns | 3.014 ns | 1,920.55 ns | 1,926.38 ns |      - |         - |
