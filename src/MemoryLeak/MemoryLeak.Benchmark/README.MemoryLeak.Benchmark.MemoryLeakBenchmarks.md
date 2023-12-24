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
| **AllocateStringStatic** |      **1** |   **753.1 ns** |   **610.3 ns** |  **33.45 ns** |   **721.2 ns** |   **787.9 ns** | **0.0124** | **0.0114** |      **1 KB** |
|       AllocateString |      1 |   705.3 ns |   693.4 ns |  38.01 ns |   678.7 ns |   748.9 ns | 0.0124 | 0.0114 |      1 KB |
|          AllocateLoH |      1 |   732.2 ns |   511.5 ns |  28.04 ns |   708.4 ns |   763.1 ns | 0.0124 | 0.0114 |      1 KB |
|        AllocateArray |      1 |   739.0 ns |   234.0 ns |  12.82 ns |   726.1 ns |   751.8 ns | 0.0124 | 0.0114 |      1 KB |
|    AllocateArrayPool |      1 |   716.5 ns |   206.1 ns |  11.30 ns |   707.6 ns |   729.2 ns | 0.0124 | 0.0114 |      1 KB |
| **AllocateStringStatic** |     **10** | **7,587.3 ns** | **1,812.6 ns** |  **99.35 ns** | **7,529.6 ns** | **7,702.0 ns** | **0.1221** | **0.1144** |     **10 KB** |
|       AllocateString |     10 | 7,243.9 ns | 3,874.0 ns | 212.35 ns | 7,012.3 ns | 7,429.5 ns | 0.1297 | 0.1221 |     10 KB |
|          AllocateLoH |     10 | 7,021.0 ns | 2,942.7 ns | 161.30 ns | 6,883.7 ns | 7,198.6 ns | 0.1297 | 0.1221 |     10 KB |
|        AllocateArray |     10 | 7,459.6 ns | 5,541.2 ns | 303.73 ns | 7,231.7 ns | 7,804.4 ns | 0.1221 | 0.1144 |     10 KB |
|    AllocateArrayPool |     10 | 7,178.1 ns | 2,288.3 ns | 125.43 ns | 7,033.6 ns | 7,257.9 ns | 0.1221 | 0.1144 |     10 KB |
