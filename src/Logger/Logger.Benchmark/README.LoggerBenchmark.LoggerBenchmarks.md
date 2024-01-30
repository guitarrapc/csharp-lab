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
| **LogWithoutIfParams**                         | **1**      |    **59.96 ns** |     **0.861 ns** |  **0.047 ns** |    **59.91 ns** |    **60.00 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    59.72 ns |     3.147 ns |  0.173 ns |    59.55 ns |    59.89 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    66.10 ns |     3.185 ns |  0.175 ns |    65.97 ns |    66.30 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    20.00 ns |     0.397 ns |  0.022 ns |    19.98 ns |    20.03 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    19.75 ns |     0.371 ns |  0.020 ns |    19.73 ns |    19.77 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.23 ns |     0.578 ns |  0.032 ns |    19.19 ns |    19.25 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **605.56 ns** |    **19.237 ns** |  **1.054 ns** |   **604.34 ns** |   **606.20 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   599.34 ns |    30.666 ns |  1.681 ns |   598.16 ns |   601.27 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   662.44 ns |    10.537 ns |  0.578 ns |   661.77 ns |   662.79 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   198.25 ns |     1.337 ns |  0.073 ns |   198.17 ns |   198.31 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   198.11 ns |    27.734 ns |  1.520 ns |   197.22 ns |   199.87 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   193.68 ns |    36.717 ns |  2.013 ns |   191.46 ns |   195.38 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,084.12 ns** |   **641.754 ns** | **35.177 ns** | **6,053.53 ns** | **6,122.55 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 5,913.41 ns |   208.913 ns | 11.451 ns | 5,901.12 ns | 5,923.78 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,739.16 ns | 1,404.343 ns | 76.977 ns | 6,694.60 ns | 6,828.04 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 1,985.37 ns |    16.682 ns |  0.914 ns | 1,984.59 ns | 1,986.38 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 1,996.96 ns |   296.445 ns | 16.249 ns | 1,985.96 ns | 2,015.62 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,931.43 ns |   136.441 ns |  7.479 ns | 1,923.27 ns | 1,937.96 ns |      - |         - |
