```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|------------------------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |    **60.21 ns** |  **15.317 ns** |  **0.840 ns** |    **59.55 ns** |    **61.16 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    59.92 ns |   8.928 ns |  0.489 ns |    59.35 ns |    60.23 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    67.47 ns |  24.962 ns |  1.368 ns |    66.42 ns |    69.02 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    19.83 ns |   0.744 ns |  0.041 ns |    19.78 ns |    19.86 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    19.91 ns |   1.639 ns |  0.090 ns |    19.80 ns |    19.96 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.48 ns |   5.778 ns |  0.317 ns |    19.11 ns |    19.66 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **614.54 ns** |  **53.522 ns** |  **2.934 ns** |   **612.64 ns** |   **617.92 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   601.24 ns |  24.374 ns |  1.336 ns |   600.11 ns |   602.71 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   684.97 ns | 527.785 ns | 28.930 ns |   662.21 ns |   717.53 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   199.06 ns |   6.000 ns |  0.329 ns |   198.87 ns |   199.44 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   197.10 ns |   2.567 ns |  0.141 ns |   196.95 ns |   197.23 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   193.78 ns |  32.794 ns |  1.798 ns |   191.80 ns |   195.31 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,015.92 ns** | **156.194 ns** |  **8.562 ns** | **6,006.54 ns** | **6,023.32 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 5,958.00 ns | 241.689 ns | 13.248 ns | 5,942.70 ns | 5,965.80 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,523.31 ns | 162.944 ns |  8.932 ns | 6,513.52 ns | 6,531.02 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 1,998.14 ns | 196.828 ns | 10.789 ns | 1,989.82 ns | 2,010.33 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 1,988.36 ns | 248.721 ns | 13.633 ns | 1,980.22 ns | 2,004.10 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,922.89 ns |  20.878 ns |  1.144 ns | 1,921.88 ns | 1,924.13 ns |      - |         - |
