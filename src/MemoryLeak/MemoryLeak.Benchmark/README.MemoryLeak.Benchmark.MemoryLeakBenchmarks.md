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
| **AllocateStringStatic** |      **1** |   **736.8 ns** |   **497.5 ns** |  **27.27 ns** |   **705.6 ns** |   **756.3 ns** | **0.0124** | **0.0114** |      **1 KB** |
|       AllocateString |      1 |   717.3 ns |   563.7 ns |  30.90 ns |   699.3 ns |   752.9 ns | 0.0124 | 0.0114 |      1 KB |
|          AllocateLoH |      1 |   707.5 ns |   300.0 ns |  16.45 ns |   696.4 ns |   726.4 ns | 0.0124 | 0.0114 |      1 KB |
|        AllocateArray |      1 |   740.4 ns |   391.5 ns |  21.46 ns |   721.0 ns |   763.5 ns | 0.0124 | 0.0114 |      1 KB |
|    AllocateArrayPool |      1 |   702.7 ns |   278.3 ns |  15.25 ns |   686.7 ns |   717.1 ns | 0.0124 | 0.0114 |      1 KB |
| **AllocateStringStatic** |     **10** | **7,595.4 ns** | **2,123.2 ns** | **116.38 ns** | **7,520.4 ns** | **7,729.5 ns** | **0.1221** | **0.1144** |     **10 KB** |
|       AllocateString |     10 | 7,180.8 ns | 2,503.3 ns | 137.22 ns | 7,097.1 ns | 7,339.1 ns | 0.1221 | 0.1144 |     10 KB |
|          AllocateLoH |     10 | 7,061.2 ns | 2,079.3 ns | 113.97 ns | 6,993.7 ns | 7,192.8 ns | 0.1221 | 0.1144 |     10 KB |
|        AllocateArray |     10 | 7,419.6 ns | 2,969.8 ns | 162.78 ns | 7,248.9 ns | 7,573.1 ns | 0.1221 | 0.1144 |     10 KB |
|    AllocateArrayPool |     10 | 7,311.8 ns | 1,500.3 ns |  82.23 ns | 7,227.3 ns | 7,391.5 ns | 0.1221 | 0.1144 |     10 KB |
