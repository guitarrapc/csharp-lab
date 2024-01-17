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
| **LogWithoutIfParams**                         | **1**      |    **60.78 ns** |   **3.593 ns** |  **0.197 ns** |    **60.62 ns** |    **61.00 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    65.63 ns |  15.525 ns |  0.851 ns |    65.00 ns |    66.60 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    65.58 ns |   4.530 ns |  0.248 ns |    65.39 ns |    65.86 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    20.84 ns |   5.785 ns |  0.317 ns |    20.58 ns |    21.19 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    19.96 ns |   0.632 ns |  0.035 ns |    19.92 ns |    19.98 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.35 ns |   3.309 ns |  0.181 ns |    19.14 ns |    19.47 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **605.98 ns** |  **56.229 ns** |  **3.082 ns** |   **602.85 ns** |   **609.02 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   598.02 ns |  34.632 ns |  1.898 ns |   595.96 ns |   599.69 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   655.73 ns |  23.393 ns |  1.282 ns |   654.88 ns |   657.21 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   198.10 ns |   0.192 ns |  0.011 ns |   198.09 ns |   198.11 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   197.18 ns |   3.802 ns |  0.208 ns |   197.03 ns |   197.42 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   191.97 ns |   6.753 ns |  0.370 ns |   191.68 ns |   192.39 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,355.02 ns** | **153.174 ns** |  **8.396 ns** | **6,346.07 ns** | **6,362.71 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 6,136.38 ns | 292.437 ns | 16.029 ns | 6,117.89 ns | 6,146.37 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,466.22 ns |  60.525 ns |  3.318 ns | 6,463.46 ns | 6,469.90 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 1,999.59 ns | 205.957 ns | 11.289 ns | 1,986.84 ns | 2,008.30 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 1,986.77 ns |  27.904 ns |  1.530 ns | 1,985.62 ns | 1,988.51 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,924.99 ns |  27.667 ns |  1.517 ns | 1,923.82 ns | 1,926.71 ns |      - |         - |
