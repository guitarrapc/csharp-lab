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
| **LogWithoutIfParams**                         | **1**      |    **60.27 ns** |   **6.177 ns** |  **0.339 ns** |    **60.03 ns** |    **60.66 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    58.89 ns |   4.275 ns |  0.234 ns |    58.62 ns |    59.07 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    64.47 ns |   4.729 ns |  0.259 ns |    64.18 ns |    64.65 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    19.78 ns |   1.167 ns |  0.064 ns |    19.71 ns |    19.83 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    19.61 ns |   2.321 ns |  0.127 ns |    19.47 ns |    19.72 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.21 ns |   0.779 ns |  0.043 ns |    19.16 ns |    19.24 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **610.20 ns** |  **25.296 ns** |  **1.387 ns** |   **608.90 ns** |   **611.66 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   603.46 ns |  28.604 ns |  1.568 ns |   601.68 ns |   604.65 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   655.29 ns |  29.333 ns |  1.608 ns |   653.46 ns |   656.47 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   198.93 ns |  21.658 ns |  1.187 ns |   198.03 ns |   200.27 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   196.87 ns |   8.983 ns |  0.492 ns |   196.33 ns |   197.30 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   192.06 ns |   5.273 ns |  0.289 ns |   191.73 ns |   192.25 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,010.64 ns** | **249.117 ns** | **13.655 ns** | **5,996.72 ns** | **6,024.01 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 6,021.74 ns | 154.554 ns |  8.472 ns | 6,013.22 ns | 6,030.16 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,466.67 ns | 158.863 ns |  8.708 ns | 6,458.88 ns | 6,476.07 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 2,001.70 ns | 455.920 ns | 24.990 ns | 1,986.57 ns | 2,030.54 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 1,983.03 ns |  63.856 ns |  3.500 ns | 1,979.45 ns | 1,986.44 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,924.23 ns |  22.637 ns |  1.241 ns | 1,923.45 ns | 1,925.66 ns |      - |         - |
