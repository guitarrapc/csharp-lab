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
|                         **LogWithoutIfParams** |      **1** |    **63.56 ns** |   **2.986 ns** |  **0.164 ns** |    **63.44 ns** |    **63.75 ns** | **0.0010** |      **88 B** |
|                            LogWithIfParams |      1 |    61.00 ns |   2.529 ns |  0.139 ns |    60.84 ns |    61.09 ns | 0.0010 |      88 B |
|                  LogAdapterWithoutIfParams |      1 |    67.65 ns |   4.596 ns |  0.252 ns |    67.36 ns |    67.81 ns | 0.0010 |      88 B |
|                   LogDefineWithoutIfParams |      1 |    21.86 ns |   6.653 ns |  0.365 ns |    21.44 ns |    22.11 ns |      - |         - |
|                LogSourceGenWithoutIfParams |      1 |    21.38 ns |   0.973 ns |  0.053 ns |    21.33 ns |    21.43 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |      1 |    19.96 ns |   3.703 ns |  0.203 ns |    19.81 ns |    20.19 ns |      - |         - |
|                         **LogWithoutIfParams** |     **10** |   **612.00 ns** |  **18.189 ns** |  **0.997 ns** |   **611.31 ns** |   **613.14 ns** | **0.0105** |     **880 B** |
|                            LogWithIfParams |     10 |   604.96 ns |  40.300 ns |  2.209 ns |   603.20 ns |   607.44 ns | 0.0105 |     880 B |
|                  LogAdapterWithoutIfParams |     10 |   671.86 ns | 198.848 ns | 10.900 ns |   659.35 ns |   679.27 ns | 0.0105 |     880 B |
|                   LogDefineWithoutIfParams |     10 |   209.07 ns |   3.712 ns |  0.203 ns |   208.93 ns |   209.30 ns |      - |         - |
|                LogSourceGenWithoutIfParams |     10 |   210.36 ns |   7.523 ns |  0.412 ns |   210.03 ns |   210.82 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |     10 |   194.12 ns |  17.830 ns |  0.977 ns |   193.33 ns |   195.21 ns |      - |         - |
|                         **LogWithoutIfParams** |    **100** | **6,036.83 ns** | **115.684 ns** |  **6.341 ns** | **6,030.96 ns** | **6,043.56 ns** | **0.0992** |   **8,800 B** |
|                            LogWithIfParams |    100 | 6,013.46 ns | 244.973 ns | 13.428 ns | 6,002.93 ns | 6,028.58 ns | 0.0992 |   8,800 B |
|                  LogAdapterWithoutIfParams |    100 | 6,568.71 ns | 234.502 ns | 12.854 ns | 6,556.94 ns | 6,582.43 ns | 0.0992 |   8,800 B |
|                   LogDefineWithoutIfParams |    100 | 2,024.11 ns |  22.920 ns |  1.256 ns | 2,022.75 ns | 2,025.23 ns |      - |         - |
|                LogSourceGenWithoutIfParams |    100 | 1,989.67 ns |  48.689 ns |  2.669 ns | 1,986.77 ns | 1,992.02 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |    100 | 1,934.63 ns |  51.054 ns |  2.798 ns | 1,932.16 ns | 1,937.67 ns |      - |         - |
