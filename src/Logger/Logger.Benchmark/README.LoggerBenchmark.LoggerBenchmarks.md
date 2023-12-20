``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT
  ShortRun : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                                     Method | Number |         Mean |      Error |    StdDev |          Min |          Max |  Gen 0 | Allocated |
|------------------------------------------- |------- |-------------:|-----------:|----------:|-------------:|-------------:|-------:|----------:|
|                         **LogWithoutIfParams** |      **1** |     **97.13 ns** |   **8.839 ns** |  **0.484 ns** |     **96.58 ns** |     **97.51 ns** | **0.0010** |      **88 B** |
|                            LogWithIfParams |      1 |     97.08 ns |   3.084 ns |  0.169 ns |     96.96 ns |     97.28 ns | 0.0010 |      88 B |
|                  LogAdapterWithoutIfParams |      1 |    101.98 ns |   4.429 ns |  0.243 ns |    101.79 ns |    102.26 ns | 0.0010 |      88 B |
|                   LogDefineWithoutIfParams |      1 |     21.44 ns |   2.512 ns |  0.138 ns |     21.35 ns |     21.59 ns |      - |         - |
|                LogSourceGenWithoutIfParams |      1 |     19.32 ns |   0.764 ns |  0.042 ns |     19.28 ns |     19.37 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |      1 |     16.79 ns |   0.386 ns |  0.021 ns |     16.76 ns |     16.81 ns |      - |         - |
|                         **LogWithoutIfParams** |     **10** |    **919.54 ns** | **181.523 ns** |  **9.950 ns** |    **912.93 ns** |    **930.98 ns** | **0.0105** |     **880 B** |
|                            LogWithIfParams |     10 |    936.18 ns |  29.409 ns |  1.612 ns |    934.93 ns |    938.00 ns | 0.0105 |     880 B |
|                  LogAdapterWithoutIfParams |     10 |    999.88 ns | 321.874 ns | 17.643 ns |    989.01 ns |  1,020.24 ns | 0.0095 |     880 B |
|                   LogDefineWithoutIfParams |     10 |    218.03 ns |  12.443 ns |  0.682 ns |    217.25 ns |    218.55 ns |      - |         - |
|                LogSourceGenWithoutIfParams |     10 |    187.55 ns |  26.305 ns |  1.442 ns |    186.68 ns |    189.21 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |     10 |    166.70 ns |   2.622 ns |  0.144 ns |    166.61 ns |    166.87 ns |      - |         - |
|                         **LogWithoutIfParams** |    **100** |  **9,075.28 ns** |  **49.687 ns** |  **2.723 ns** |  **9,072.72 ns** |  **9,078.14 ns** | **0.0916** |   **8,800 B** |
|                            LogWithIfParams |    100 |  9,249.83 ns | 328.202 ns | 17.990 ns |  9,235.43 ns |  9,270.00 ns | 0.0916 |   8,800 B |
|                  LogAdapterWithoutIfParams |    100 | 10,656.98 ns | 121.592 ns |  6.665 ns | 10,649.33 ns | 10,661.53 ns | 0.0916 |   8,800 B |
|                   LogDefineWithoutIfParams |    100 |  2,192.82 ns | 231.810 ns | 12.706 ns |  2,179.47 ns |  2,204.77 ns |      - |         - |
|                LogSourceGenWithoutIfParams |    100 |  1,877.47 ns |  71.916 ns |  3.942 ns |  1,873.08 ns |  1,880.71 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |    100 |  1,671.99 ns |  20.345 ns |  1.115 ns |  1,671.12 ns |  1,673.25 ns |      - |         - |
