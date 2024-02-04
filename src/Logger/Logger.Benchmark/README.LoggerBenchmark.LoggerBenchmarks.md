```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|------------------------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |    **60.03 ns** |   **1.959 ns** |  **0.107 ns** |    **59.93 ns** |    **60.14 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    60.70 ns |   3.810 ns |  0.209 ns |    60.48 ns |    60.90 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    66.16 ns |   7.615 ns |  0.417 ns |    65.88 ns |    66.64 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    20.53 ns |   2.572 ns |  0.141 ns |    20.43 ns |    20.69 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    19.96 ns |   0.509 ns |  0.028 ns |    19.94 ns |    19.99 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.33 ns |   4.236 ns |  0.232 ns |    19.15 ns |    19.59 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **608.89 ns** |  **16.584 ns** |  **0.909 ns** |   **608.01 ns** |   **609.83 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   607.65 ns |  14.103 ns |  0.773 ns |   606.79 ns |   608.29 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   654.79 ns |  17.093 ns |  0.937 ns |   654.14 ns |   655.86 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   197.93 ns |   0.544 ns |  0.030 ns |   197.91 ns |   197.96 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   197.53 ns |   3.079 ns |  0.169 ns |   197.34 ns |   197.65 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   193.46 ns |  45.421 ns |  2.490 ns |   191.67 ns |   196.30 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,225.03 ns** |  **68.830 ns** |  **3.773 ns** | **6,220.80 ns** | **6,228.04 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 5,913.57 ns | 277.632 ns | 15.218 ns | 5,898.53 ns | 5,928.96 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,540.90 ns | 109.174 ns |  5.984 ns | 6,535.80 ns | 6,547.49 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 1,990.93 ns |  97.165 ns |  5.326 ns | 1,987.40 ns | 1,997.05 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 1,990.26 ns |  53.588 ns |  2.937 ns | 1,987.76 ns | 1,993.50 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,922.77 ns |  38.675 ns |  2.120 ns | 1,921.03 ns | 1,925.13 ns |      - |         - |
