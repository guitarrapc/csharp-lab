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
| **LogWithoutIfParams**                         | **1**      |    **60.58 ns** |   **3.281 ns** |  **0.180 ns** |    **60.41 ns** |    **60.77 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    59.26 ns |   2.412 ns |  0.132 ns |    59.18 ns |    59.42 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    67.06 ns |  21.688 ns |  1.189 ns |    66.20 ns |    68.42 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    20.06 ns |   4.170 ns |  0.229 ns |    19.84 ns |    20.30 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    19.71 ns |   0.171 ns |  0.009 ns |    19.71 ns |    19.72 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.31 ns |   4.899 ns |  0.269 ns |    19.01 ns |    19.50 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **607.87 ns** |  **42.759 ns** |  **2.344 ns** |   **605.26 ns** |   **609.78 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   604.98 ns |  33.257 ns |  1.823 ns |   603.78 ns |   607.08 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   659.32 ns | 146.667 ns |  8.039 ns |   652.91 ns |   668.34 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   198.30 ns |  15.935 ns |  0.873 ns |   197.53 ns |   199.25 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   196.61 ns |   6.726 ns |  0.369 ns |   196.22 ns |   196.95 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   192.27 ns |  13.664 ns |  0.749 ns |   191.44 ns |   192.90 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,052.38 ns** | **514.098 ns** | **28.179 ns** | **6,021.31 ns** | **6,076.29 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 5,994.78 ns | 142.575 ns |  7.815 ns | 5,986.22 ns | 6,001.54 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,442.80 ns | 293.383 ns | 16.081 ns | 6,424.25 ns | 6,452.77 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 1,980.90 ns | 146.450 ns |  8.027 ns | 1,974.58 ns | 1,989.93 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 1,995.71 ns | 134.863 ns |  7.392 ns | 1,990.52 ns | 2,004.18 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,933.82 ns | 345.168 ns | 18.920 ns | 1,921.48 ns | 1,955.60 ns |      - |         - |
