```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|------------------------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |    **61.65 ns** |   **6.307 ns** |  **0.346 ns** |    **61.27 ns** |    **61.95 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    59.60 ns |   6.107 ns |  0.335 ns |    59.34 ns |    59.98 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    65.65 ns |  27.252 ns |  1.494 ns |    64.57 ns |    67.36 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    20.03 ns |   4.369 ns |  0.239 ns |    19.81 ns |    20.28 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    20.01 ns |   4.970 ns |  0.272 ns |    19.79 ns |    20.32 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.44 ns |   0.063 ns |  0.003 ns |    19.43 ns |    19.44 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **603.40 ns** |   **9.962 ns** |  **0.546 ns** |   **602.80 ns** |   **603.87 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   620.81 ns | 221.397 ns | 12.136 ns |   606.80 ns |   627.88 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   663.54 ns |  44.176 ns |  2.421 ns |   661.38 ns |   666.16 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   197.85 ns |   1.452 ns |  0.080 ns |   197.76 ns |   197.90 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   197.55 ns |   1.304 ns |  0.071 ns |   197.48 ns |   197.62 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   193.90 ns |  37.137 ns |  2.036 ns |   191.73 ns |   195.77 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **5,947.13 ns** | **119.215 ns** |  **6.535 ns** | **5,939.60 ns** | **5,951.28 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 6,363.35 ns | 180.802 ns |  9.910 ns | 6,356.99 ns | 6,374.77 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,460.04 ns | 245.376 ns | 13.450 ns | 6,444.62 ns | 6,469.36 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 1,998.71 ns | 416.063 ns | 22.806 ns | 1,985.03 ns | 2,025.03 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 1,982.21 ns |  71.520 ns |  3.920 ns | 1,979.25 ns | 1,986.65 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,923.83 ns |  48.699 ns |  2.669 ns | 1,920.90 ns | 1,926.11 ns |      - |         - |
