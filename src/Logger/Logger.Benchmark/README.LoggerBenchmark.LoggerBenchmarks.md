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
| **LogWithoutIfParams**                         | **1**      |    **61.37 ns** |   **0.582 ns** |  **0.032 ns** |    **61.34 ns** |    **61.40 ns** | **0.0010** |      **88 B** |
| LogWithIfParams                            | 1      |    61.10 ns |   7.426 ns |  0.407 ns |    60.86 ns |    61.57 ns | 0.0010 |      88 B |
| LogAdapterWithoutIfParams                  | 1      |    67.70 ns |  47.494 ns |  2.603 ns |    66.18 ns |    70.71 ns | 0.0010 |      88 B |
| LogDefineWithoutIfParams                   | 1      |    19.89 ns |   3.012 ns |  0.165 ns |    19.78 ns |    20.08 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 1      |    19.84 ns |   0.333 ns |  0.018 ns |    19.82 ns |    19.85 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 1      |    19.29 ns |   2.993 ns |  0.164 ns |    19.15 ns |    19.47 ns |      - |         - |
| **LogWithoutIfParams**                         | **10**     |   **637.87 ns** | **682.659 ns** | **37.419 ns** |   **614.69 ns** |   **681.04 ns** | **0.0105** |     **880 B** |
| LogWithIfParams                            | 10     |   602.40 ns |  23.748 ns |  1.302 ns |   601.39 ns |   603.87 ns | 0.0105 |     880 B |
| LogAdapterWithoutIfParams                  | 10     |   697.69 ns | 171.460 ns |  9.398 ns |   691.22 ns |   708.47 ns | 0.0105 |     880 B |
| LogDefineWithoutIfParams                   | 10     |   198.94 ns |   0.887 ns |  0.049 ns |   198.88 ns |   198.97 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 10     |   196.99 ns |   2.272 ns |  0.125 ns |   196.86 ns |   197.10 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 10     |   192.23 ns |   7.893 ns |  0.433 ns |   191.88 ns |   192.71 ns |      - |         - |
| **LogWithoutIfParams**                         | **100**    | **6,325.54 ns** | **273.333 ns** | **14.982 ns** | **6,310.18 ns** | **6,340.11 ns** | **0.0992** |    **8800 B** |
| LogWithIfParams                            | 100    | 5,978.22 ns | 350.947 ns | 19.237 ns | 5,962.53 ns | 5,999.68 ns | 0.0992 |    8800 B |
| LogAdapterWithoutIfParams                  | 100    | 6,571.01 ns | 703.298 ns | 38.550 ns | 6,527.97 ns | 6,602.36 ns | 0.0992 |    8800 B |
| LogDefineWithoutIfParams                   | 100    | 1,987.78 ns |  13.804 ns |  0.757 ns | 1,986.91 ns | 1,988.22 ns |      - |         - |
| LogSourceGenWithoutIfParams                | 100    | 1,982.69 ns |  30.691 ns |  1.682 ns | 1,981.45 ns | 1,984.60 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 100    | 1,925.15 ns |  32.287 ns |  1.770 ns | 1,923.72 ns | 1,927.13 ns |      - |         - |
