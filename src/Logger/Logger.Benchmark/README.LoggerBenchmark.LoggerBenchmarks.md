```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean        | Error        | StdDev    | Min         | Max         | Gen0   | Allocated |
|------------------------------------------- |------- |------------:|-------------:|----------:|------------:|------------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |    **60.72 ns** |     **2.974 ns** |  **0.163 ns** |    **60.54 ns** |    **60.86 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    61.44 ns |    11.358 ns |  0.623 ns |    60.99 ns |    62.15 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    69.34 ns |    29.688 ns |  1.627 ns |    68.38 ns |    71.22 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    19.81 ns |     0.711 ns |  0.039 ns |    19.78 ns |    19.86 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    19.89 ns |     1.271 ns |  0.070 ns |    19.85 ns |    19.97 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.61 ns |     4.832 ns |  0.265 ns |    19.43 ns |    19.91 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **678.23 ns** |   **662.500 ns** | **36.314 ns** |   **636.31 ns** |   **699.77 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   600.70 ns |    20.422 ns |  1.119 ns |   599.41 ns |   601.39 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   682.33 ns |    92.443 ns |  5.067 ns |   676.51 ns |   685.78 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   198.44 ns |     4.668 ns |  0.256 ns |   198.19 ns |   198.71 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   197.39 ns |     3.759 ns |  0.206 ns |   197.18 ns |   197.59 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   191.91 ns |     7.228 ns |  0.396 ns |   191.45 ns |   192.15 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,014.26 ns** |   **859.081 ns** | **47.089 ns** | **5,967.39 ns** | **6,061.56 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 6,029.33 ns | 1,236.018 ns | 67.750 ns | 5,955.31 ns | 6,088.27 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,628.84 ns |   572.560 ns | 31.384 ns | 6,597.17 ns | 6,659.93 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 2,013.44 ns |   686.190 ns | 37.612 ns | 1,986.51 ns | 2,056.42 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 1,990.98 ns |   143.498 ns |  7.866 ns | 1,984.75 ns | 1,999.82 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,929.19 ns |    43.631 ns |  2.392 ns | 1,926.48 ns | 1,931.01 ns |      - |         - |
