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
| **AllocateStringStatic** |      **1** |   **734.6 ns** |   **326.9 ns** |  **17.92 ns** |   **715.4 ns** |   **750.9 ns** | **0.0124** | **0.0114** |      **1 KB** |
|       AllocateString |      1 |   730.8 ns |   489.8 ns |  26.85 ns |   709.7 ns |   761.0 ns | 0.0124 | 0.0114 |      1 KB |
|          AllocateLoH |      1 |   696.9 ns |   401.0 ns |  21.98 ns |   672.8 ns |   715.9 ns | 0.0124 | 0.0114 |      1 KB |
|        AllocateArray |      1 |   742.8 ns |   357.1 ns |  19.57 ns |   722.8 ns |   761.9 ns | 0.0124 | 0.0114 |      1 KB |
|    AllocateArrayPool |      1 |   721.6 ns |   180.5 ns |   9.89 ns |   711.0 ns |   730.6 ns | 0.0124 | 0.0114 |      1 KB |
| **AllocateStringStatic** |     **10** | **7,666.0 ns** | **1,948.9 ns** | **106.83 ns** | **7,544.1 ns** | **7,743.4 ns** | **0.1221** | **0.1144** |     **10 KB** |
|       AllocateString |     10 | 7,270.0 ns | 4,687.7 ns | 256.95 ns | 6,973.8 ns | 7,433.2 ns | 0.1221 | 0.1144 |     10 KB |
|          AllocateLoH |     10 | 7,082.1 ns | 2,089.3 ns | 114.52 ns | 6,949.9 ns | 7,150.4 ns | 0.1221 | 0.1144 |     10 KB |
|        AllocateArray |     10 | 7,400.1 ns | 1,269.1 ns |  69.56 ns | 7,339.3 ns | 7,476.0 ns | 0.1221 | 0.1144 |     10 KB |
|    AllocateArrayPool |     10 | 7,182.7 ns | 1,691.8 ns |  92.74 ns | 7,119.0 ns | 7,289.1 ns | 0.1221 | 0.1144 |     10 KB |
