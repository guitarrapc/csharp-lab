```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|------------------------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |    **60.97 ns** |   **3.827 ns** |  **0.210 ns** |    **60.75 ns** |    **61.17 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    60.59 ns |   2.296 ns |  0.126 ns |    60.48 ns |    60.73 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    66.40 ns |   3.371 ns |  0.185 ns |    66.23 ns |    66.59 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    19.92 ns |   3.794 ns |  0.208 ns |    19.78 ns |    20.16 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    19.70 ns |   0.240 ns |  0.013 ns |    19.69 ns |    19.71 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    44.58 ns |   6.196 ns |  0.340 ns |    44.32 ns |    44.96 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **624.91 ns** | **231.398 ns** | **12.684 ns** |   **614.39 ns** |   **638.99 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   634.96 ns |  15.376 ns |  0.843 ns |   634.01 ns |   635.63 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   667.86 ns |  37.830 ns |  2.074 ns |   665.64 ns |   669.74 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   198.28 ns |   6.821 ns |  0.374 ns |   197.98 ns |   198.70 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   197.71 ns |   5.047 ns |  0.277 ns |   197.45 ns |   198.00 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   193.07 ns |  12.768 ns |  0.700 ns |   192.49 ns |   193.85 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,016.67 ns** | **214.192 ns** | **11.741 ns** | **6,007.27 ns** | **6,029.83 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 5,948.78 ns | 352.745 ns | 19.335 ns | 5,929.98 ns | 5,968.61 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,709.97 ns | 657.653 ns | 36.048 ns | 6,687.91 ns | 6,751.57 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 1,989.88 ns |  85.635 ns |  4.694 ns | 1,986.14 ns | 1,995.15 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 1,988.62 ns |  68.390 ns |  3.749 ns | 1,986.05 ns | 1,992.92 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,926.78 ns | 110.234 ns |  6.042 ns | 1,922.40 ns | 1,933.67 ns |      - |         - |
