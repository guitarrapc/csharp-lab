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
| **LogWithoutIfParams**                         | **1**      |    **60.73 ns** |   **4.750 ns** |  **0.260 ns** |    **60.56 ns** |    **61.03 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    65.39 ns |   4.096 ns |  0.225 ns |    65.18 ns |    65.62 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    66.13 ns |  18.859 ns |  1.034 ns |    65.50 ns |    67.33 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    28.26 ns |   3.008 ns |  0.165 ns |    28.09 ns |    28.42 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    19.86 ns |   5.138 ns |  0.282 ns |    19.69 ns |    20.19 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.15 ns |   0.243 ns |  0.013 ns |    19.14 ns |    19.16 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **613.79 ns** |  **28.944 ns** |  **1.586 ns** |   **611.96 ns** |   **614.74 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   608.82 ns | 263.666 ns | 14.452 ns |   599.65 ns |   625.48 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   662.01 ns | 123.350 ns |  6.761 ns |   658.02 ns |   669.82 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   198.03 ns |   1.216 ns |  0.067 ns |   197.96 ns |   198.10 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   197.34 ns |   3.423 ns |  0.188 ns |   197.21 ns |   197.56 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   195.22 ns |  34.047 ns |  1.866 ns |   194.01 ns |   197.37 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,026.39 ns** | **291.964 ns** | **16.004 ns** | **6,008.23 ns** | **6,038.43 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 6,647.19 ns | 480.413 ns | 26.333 ns | 6,618.53 ns | 6,670.32 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,658.03 ns | 111.210 ns |  6.096 ns | 6,651.14 ns | 6,662.73 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 1,986.17 ns |  53.308 ns |  2.922 ns | 1,983.83 ns | 1,989.44 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 2,006.02 ns | 765.164 ns | 41.941 ns | 1,980.67 ns | 2,054.44 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,929.55 ns | 160.420 ns |  8.793 ns | 1,921.79 ns | 1,939.10 ns |      - |         - |
