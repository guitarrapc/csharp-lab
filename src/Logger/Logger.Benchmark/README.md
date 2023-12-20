# LoggerBenchmark.Benchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                                     Method | Number |        Mean |      Error |    StdDev |         Min |         Max |  Gen 0 | Allocated |
|------------------------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
|                         **LogWithoutIfParams** |      **1** |    **63.65 ns** |  **26.178 ns** |  **1.435 ns** |    **62.77 ns** |    **65.31 ns** | **0.0010** |      **88 B** |
|                            LogWithIfParams |      1 |    61.55 ns |  11.286 ns |  0.619 ns |    61.15 ns |    62.27 ns | 0.0010 |      88 B |
|                  LogAdapterWithoutIfParams |      1 |    80.77 ns |  45.382 ns |  2.488 ns |    78.24 ns |    83.22 ns | 0.0010 |      88 B |
|                   LogDefineWithoutIfParams |      1 |    22.00 ns |  12.641 ns |  0.693 ns |    21.47 ns |    22.78 ns |      - |         - |
|                LogSourceGenWithoutIfParams |      1 |    21.76 ns |   4.537 ns |  0.249 ns |    21.55 ns |    22.03 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |      1 |    19.86 ns |   0.713 ns |  0.039 ns |    19.82 ns |    19.90 ns |      - |         - |
|                         **LogWithoutIfParams** |     **10** |   **620.60 ns** |  **18.176 ns** |  **0.996 ns** |   **619.58 ns** |   **621.57 ns** | **0.0105** |     **880 B** |
|                            LogWithIfParams |     10 |   716.63 ns |  68.646 ns |  3.763 ns |   713.65 ns |   720.86 ns | 0.0105 |     880 B |
|                  LogAdapterWithoutIfParams |     10 |   667.98 ns |   7.418 ns |  0.407 ns |   667.52 ns |   668.29 ns | 0.0105 |     880 B |
|                   LogDefineWithoutIfParams |     10 |   209.26 ns |   7.008 ns |  0.384 ns |   208.82 ns |   209.51 ns |      - |         - |
|                LogSourceGenWithoutIfParams |     10 |   211.40 ns |  41.684 ns |  2.285 ns |   209.02 ns |   213.57 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |     10 |   193.92 ns |  12.944 ns |  0.710 ns |   193.31 ns |   194.70 ns |      - |         - |
|                         **LogWithoutIfParams** |    **100** | **5,987.24 ns** | **277.361 ns** | **15.203 ns** | **5,971.91 ns** | **6,002.31 ns** | **0.0992** |   **8,800 B** |
|                            LogWithIfParams |    100 | 6,012.89 ns | 233.541 ns | 12.801 ns | 6,000.75 ns | 6,026.26 ns | 0.0992 |   8,800 B |
|                  LogAdapterWithoutIfParams |    100 | 6,542.27 ns | 141.756 ns |  7.770 ns | 6,533.84 ns | 6,549.15 ns | 0.0992 |   8,800 B |
|                   LogDefineWithoutIfParams |    100 | 2,022.77 ns |  86.147 ns |  4.722 ns | 2,017.36 ns | 2,026.05 ns |      - |         - |
|                LogSourceGenWithoutIfParams |    100 | 1,993.74 ns |  51.465 ns |  2.821 ns | 1,990.55 ns | 1,995.92 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |    100 | 1,931.03 ns |  50.515 ns |  2.769 ns | 1,929.17 ns | 1,934.21 ns |      - |         - |
