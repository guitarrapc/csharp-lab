``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT
  ShortRun : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                                     Method | Number |        Mean |      Error |    StdDev |         Min |         Max |  Gen 0 | Allocated |
|------------------------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
|                         **LogWithoutIfParams** |      **1** |    **90.92 ns** |   **0.221 ns** |  **0.012 ns** |    **90.90 ns** |    **90.93 ns** | **0.0010** |      **88 B** |
|                            LogWithIfParams |      1 |    97.33 ns |  11.329 ns |  0.621 ns |    96.91 ns |    98.04 ns | 0.0010 |      88 B |
|                  LogAdapterWithoutIfParams |      1 |    98.34 ns |   1.265 ns |  0.069 ns |    98.29 ns |    98.42 ns | 0.0010 |      88 B |
|                   LogDefineWithoutIfParams |      1 |    20.88 ns |   0.232 ns |  0.013 ns |    20.86 ns |    20.88 ns |      - |         - |
|                LogSourceGenWithoutIfParams |      1 |    19.23 ns |   0.305 ns |  0.017 ns |    19.21 ns |    19.25 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |      1 |    16.82 ns |   0.846 ns |  0.046 ns |    16.79 ns |    16.87 ns |      - |         - |
|                         **LogWithoutIfParams** |     **10** |   **913.78 ns** |   **8.035 ns** |  **0.440 ns** |   **913.33 ns** |   **914.22 ns** | **0.0105** |     **880 B** |
|                            LogWithIfParams |     10 |   935.25 ns |  13.751 ns |  0.754 ns |   934.76 ns |   936.12 ns | 0.0105 |     880 B |
|                  LogAdapterWithoutIfParams |     10 | 1,006.89 ns | 182.585 ns | 10.008 ns |   998.96 ns | 1,018.14 ns | 0.0095 |     880 B |
|                   LogDefineWithoutIfParams |     10 |   212.10 ns |   3.084 ns |  0.169 ns |   211.95 ns |   212.28 ns |      - |         - |
|                LogSourceGenWithoutIfParams |     10 |   187.46 ns |   6.365 ns |  0.349 ns |   187.24 ns |   187.86 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |     10 |   167.55 ns |  15.650 ns |  0.858 ns |   167.03 ns |   168.54 ns |      - |         - |
|                         **LogWithoutIfParams** |    **100** | **9,068.11 ns** | **258.093 ns** | **14.147 ns** | **9,057.44 ns** | **9,084.16 ns** | **0.0916** |   **8,800 B** |
|                            LogWithIfParams |    100 | 9,240.86 ns | 276.750 ns | 15.170 ns | 9,226.84 ns | 9,256.96 ns | 0.0916 |   8,800 B |
|                  LogAdapterWithoutIfParams |    100 | 9,836.47 ns | 128.803 ns |  7.060 ns | 9,829.84 ns | 9,843.89 ns | 0.0916 |   8,800 B |
|                   LogDefineWithoutIfParams |    100 | 2,199.98 ns | 438.558 ns | 24.039 ns | 2,181.29 ns | 2,227.10 ns |      - |         - |
|                LogSourceGenWithoutIfParams |    100 | 1,884.28 ns |  17.351 ns |  0.951 ns | 1,883.53 ns | 1,885.35 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |    100 | 1,670.21 ns |  74.555 ns |  4.087 ns | 1,666.86 ns | 1,674.76 ns |      - |         - |
