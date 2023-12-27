```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean        | Error        | StdDev     | Min         | Max         | Gen0   | Allocated |
|------------------------------------------- |------- |------------:|-------------:|-----------:|------------:|------------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |    **62.97 ns** |    **12.225 ns** |   **0.670 ns** |    **62.49 ns** |    **63.74 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    59.44 ns |     3.319 ns |   0.182 ns |    59.29 ns |    59.64 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    67.72 ns |     3.982 ns |   0.218 ns |    67.56 ns |    67.97 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    20.30 ns |     7.306 ns |   0.400 ns |    19.83 ns |    20.54 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    19.85 ns |     0.381 ns |   0.021 ns |    19.83 ns |    19.87 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.17 ns |     0.710 ns |   0.039 ns |    19.14 ns |    19.21 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **623.16 ns** |   **210.336 ns** |  **11.529 ns** |   **614.78 ns** |   **636.31 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   616.61 ns |     9.157 ns |   0.502 ns |   616.27 ns |   617.19 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   708.00 ns |    55.898 ns |   3.064 ns |   705.08 ns |   711.19 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   198.72 ns |     0.453 ns |   0.025 ns |   198.70 ns |   198.74 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   196.96 ns |     2.241 ns |   0.123 ns |   196.84 ns |   197.08 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   195.97 ns |     2.979 ns |   0.163 ns |   195.84 ns |   196.15 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,093.73 ns** |   **330.779 ns** |  **18.131 ns** | **6,074.56 ns** | **6,110.60 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 6,457.00 ns | 3,004.843 ns | 164.706 ns | 6,347.46 ns | 6,646.41 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,579.03 ns |   446.591 ns |  24.479 ns | 6,564.71 ns | 6,607.30 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 2,010.74 ns |   677.023 ns |  37.110 ns | 1,986.53 ns | 2,053.47 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 1,986.64 ns |    26.942 ns |   1.477 ns | 1,985.04 ns | 1,987.94 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,931.72 ns |   133.419 ns |   7.313 ns | 1,925.24 ns | 1,939.65 ns |      - |         - |
