``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|               Method | Number |       Mean |      Error |    StdDev |        Min |        Max |  Gen 0 |  Gen 1 | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** |      **1** |   **787.5 ns** |   **448.1 ns** |  **24.56 ns** |   **759.2 ns** |   **803.2 ns** | **0.0124** | **0.0114** |      **1 KB** |
|       AllocateString |      1 |   734.2 ns |   547.2 ns |  30.00 ns |   700.6 ns |   758.4 ns | 0.0124 | 0.0114 |      1 KB |
|          AllocateLoH |      1 |   704.7 ns |   577.4 ns |  31.65 ns |   672.6 ns |   735.8 ns | 0.0124 | 0.0114 |      1 KB |
|        AllocateArray |      1 |   769.5 ns |   492.9 ns |  27.02 ns |   744.2 ns |   798.0 ns | 0.0124 | 0.0114 |      1 KB |
|    AllocateArrayPool |      1 |   740.8 ns |   450.8 ns |  24.71 ns |   719.1 ns |   767.7 ns | 0.0124 | 0.0114 |      1 KB |
| **AllocateStringStatic** |     **10** | **7,756.0 ns** | **2,868.6 ns** | **157.24 ns** | **7,590.6 ns** | **7,903.6 ns** | **0.1221** | **0.1144** |     **10 KB** |
|       AllocateString |     10 | 7,352.1 ns | 1,210.8 ns |  66.37 ns | 7,309.2 ns | 7,428.5 ns | 0.1221 | 0.1144 |     10 KB |
|          AllocateLoH |     10 | 7,099.0 ns | 4,869.3 ns | 266.90 ns | 6,791.7 ns | 7,272.3 ns | 0.1221 | 0.1144 |     10 KB |
|        AllocateArray |     10 | 7,273.4 ns | 2,136.2 ns | 117.09 ns | 7,155.1 ns | 7,389.3 ns | 0.1221 | 0.1144 |     10 KB |
|    AllocateArrayPool |     10 | 7,026.8 ns | 5,498.7 ns | 301.40 ns | 6,746.9 ns | 7,345.9 ns | 0.1221 | 0.1144 |     10 KB |
