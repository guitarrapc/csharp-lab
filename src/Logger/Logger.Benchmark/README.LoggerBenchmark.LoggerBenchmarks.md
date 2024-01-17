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
| **LogWithoutIfParams**                         | **1**      |    **60.14 ns** |   **0.155 ns** |  **0.008 ns** |    **60.13 ns** |    **60.15 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    59.84 ns |  23.185 ns |  1.271 ns |    58.84 ns |    61.27 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    65.96 ns |  13.714 ns |  0.752 ns |    65.51 ns |    66.83 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    20.06 ns |   3.041 ns |  0.167 ns |    19.87 ns |    20.16 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    19.91 ns |   5.866 ns |  0.322 ns |    19.69 ns |    20.28 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.16 ns |   0.780 ns |  0.043 ns |    19.13 ns |    19.21 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **655.68 ns** | **184.368 ns** | **10.106 ns** |   **649.77 ns** |   **667.35 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   602.44 ns |  27.861 ns |  1.527 ns |   601.30 ns |   604.17 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   668.88 ns |  17.315 ns |  0.949 ns |   668.09 ns |   669.93 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   198.67 ns |  10.785 ns |  0.591 ns |   197.98 ns |   199.01 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   197.00 ns |   1.160 ns |  0.064 ns |   196.96 ns |   197.07 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   192.78 ns |  27.569 ns |  1.511 ns |   191.05 ns |   193.85 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,333.98 ns** | **688.485 ns** | **37.738 ns** | **6,290.74 ns** | **6,360.25 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 5,899.55 ns | 103.392 ns |  5.667 ns | 5,893.01 ns | 5,903.02 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,877.91 ns | 244.854 ns | 13.421 ns | 6,863.21 ns | 6,889.51 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 2,093.23 ns | 110.665 ns |  6.066 ns | 2,089.43 ns | 2,100.23 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 1,979.91 ns |   6.006 ns |  0.329 ns | 1,979.53 ns | 1,980.16 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,933.43 ns |  34.727 ns |  1.903 ns | 1,931.33 ns | 1,935.04 ns |      - |         - |
