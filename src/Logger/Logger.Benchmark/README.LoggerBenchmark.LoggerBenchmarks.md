```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                     | Number | Mean        | Error        | StdDev     | Min         | Max         | Gen0   | Allocated |
|------------------------------------------- |------- |------------:|-------------:|-----------:|------------:|------------:|-------:|----------:|
| **LogWithoutIfParams**                         | **1**      |    **60.81 ns** |     **4.854 ns** |   **0.266 ns** |    **60.51 ns** |    **61.00 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    58.77 ns |     4.321 ns |   0.237 ns |    58.50 ns |    58.92 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    65.49 ns |    16.090 ns |   0.882 ns |    64.92 ns |    66.50 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    19.88 ns |     2.642 ns |   0.145 ns |    19.76 ns |    20.04 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    19.83 ns |     2.361 ns |   0.129 ns |    19.68 ns |    19.92 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.22 ns |     1.235 ns |   0.068 ns |    19.17 ns |    19.30 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **603.39 ns** |    **32.769 ns** |   **1.796 ns** |   **601.32 ns** |   **604.59 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   596.71 ns |    32.424 ns |   1.777 ns |   595.56 ns |   598.76 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   677.41 ns |   153.220 ns |   8.399 ns |   672.15 ns |   687.10 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   199.33 ns |    10.541 ns |   0.578 ns |   198.94 ns |   200.00 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   197.69 ns |     4.071 ns |   0.223 ns |   197.44 ns |   197.84 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   191.86 ns |     6.776 ns |   0.371 ns |   191.44 ns |   192.12 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,015.24 ns** | **2,008.931 ns** | **110.116 ns** | **5,945.50 ns** | **6,142.18 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 5,997.97 ns | 1,896.167 ns | 103.935 ns | 5,886.49 ns | 6,092.20 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,436.99 ns |   437.800 ns |  23.997 ns | 6,416.61 ns | 6,463.44 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 1,998.05 ns |   197.593 ns |  10.831 ns | 1,985.85 ns | 2,006.54 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 1,986.87 ns |    22.691 ns |   1.244 ns | 1,985.46 ns | 1,987.80 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,933.10 ns |   190.710 ns |  10.453 ns | 1,921.78 ns | 1,942.39 ns |      - |         - |
