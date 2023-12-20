``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT
  ShortRun : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                       Method | Number |         Mean |        Error |     StdDev |          Min |          Max |  Gen 0 | Allocated |
|----------------------------- |------- |-------------:|-------------:|-----------:|-------------:|-------------:|-------:|----------:|
|             **ToBinaryArrayInt** |      **1** |     **18.58 ns** |     **9.824 ns** |   **0.538 ns** |     **18.08 ns** |     **19.15 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString |      1 |     71.86 ns |    52.851 ns |   2.897 ns |     70.14 ns |     75.20 ns | 0.0011 |      96 B |
|          ToBinaryArrayIntMod |      1 |     20.14 ns |     4.271 ns |   0.234 ns |     19.90 ns |     20.37 ns | 0.0004 |      32 B |
|    ToBinaryArrayIntModNumber |      1 |     13.13 ns |     0.345 ns |   0.019 ns |     13.11 ns |     13.15 ns | 0.0004 |      32 B |
|             **ToBinaryArrayInt** |     **10** |    **193.21 ns** |    **17.164 ns** |   **0.941 ns** |    **192.36 ns** |    **194.22 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString |     10 |    833.98 ns |    67.732 ns |   3.713 ns |    831.72 ns |    838.27 ns | 0.0114 |   1,024 B |
|          ToBinaryArrayIntMod |     10 |    213.24 ns |    40.632 ns |   2.227 ns |    210.79 ns |    215.15 ns | 0.0038 |     320 B |
|    ToBinaryArrayIntModNumber |     10 |    148.00 ns |    15.080 ns |   0.827 ns |    147.20 ns |    148.85 ns | 0.0038 |     320 B |
|             **ToBinaryArrayInt** |    **100** |  **1,849.50 ns** |   **244.783 ns** |  **13.417 ns** |  **1,835.13 ns** |  **1,861.70 ns** | **0.0381** |   **3,200 B** |
| ToBinaryArrayConvertToString |    100 |  9,272.54 ns | 2,099.111 ns | 115.059 ns |  9,181.07 ns |  9,401.72 ns | 0.1221 |  10,928 B |
|          ToBinaryArrayIntMod |    100 |  2,047.33 ns |    25.960 ns |   1.423 ns |  2,045.72 ns |  2,048.40 ns | 0.0381 |   3,200 B |
|    ToBinaryArrayIntModNumber |    100 |  1,787.61 ns |   136.307 ns |   7.471 ns |  1,781.30 ns |  1,795.86 ns | 0.0381 |   3,200 B |
|             **ToBinaryArrayInt** |    **255** |  **4,658.81 ns** |    **96.748 ns** |   **5.303 ns** |  **4,652.93 ns** |  **4,663.22 ns** | **0.0916** |   **8,160 B** |
| ToBinaryArrayConvertToString |    255 | 22,774.85 ns | 1,454.544 ns |  79.728 ns | 22,683.02 ns | 22,826.37 ns | 0.2747 |  23,208 B |
|          ToBinaryArrayIntMod |    255 |  5,224.93 ns |   265.370 ns |  14.546 ns |  5,215.06 ns |  5,241.63 ns | 0.0916 |   8,160 B |
|    ToBinaryArrayIntModNumber |    255 |  4,889.08 ns |   129.939 ns |   7.122 ns |  4,881.81 ns |  4,896.04 ns | 0.0916 |   8,160 B |
