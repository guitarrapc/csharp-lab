``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 7.0.14 (7.0.1423.51910), X64 RyuJIT
  ShortRun : .NET 7.0.14 (7.0.1423.51910), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|               Method | Number |       Mean |      Error |    StdDev |        Min |        Max |  Gen 0 |  Gen 1 | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** |      **1** |   **757.5 ns** |   **119.3 ns** |   **6.54 ns** |   **751.3 ns** |   **764.4 ns** | **0.0124** | **0.0114** |      **1 KB** |
|       AllocateString |      1 |   702.1 ns |   468.0 ns |  25.65 ns |   685.6 ns |   731.7 ns | 0.0124 | 0.0114 |      1 KB |
|          AllocateLoH |      1 |   705.9 ns |   712.9 ns |  39.08 ns |   678.0 ns |   750.6 ns | 0.0124 | 0.0114 |      1 KB |
|        AllocateArray |      1 |   725.8 ns |   431.5 ns |  23.65 ns |   700.9 ns |   747.9 ns | 0.0124 | 0.0114 |      1 KB |
|    AllocateArrayPool |      1 |   730.6 ns |   300.2 ns |  16.45 ns |   718.0 ns |   749.2 ns | 0.0124 | 0.0114 |      1 KB |
| **AllocateStringStatic** |     **10** | **7,566.2 ns** | **3,425.0 ns** | **187.74 ns** | **7,397.0 ns** | **7,768.2 ns** | **0.1221** | **0.1144** |     **10 KB** |
|       AllocateString |     10 | 7,424.0 ns | 1,362.2 ns |  74.67 ns | 7,345.1 ns | 7,493.6 ns | 0.1221 | 0.1144 |     10 KB |
|          AllocateLoH |     10 | 7,164.4 ns | 3,012.5 ns | 165.13 ns | 7,057.9 ns | 7,354.6 ns | 0.1221 | 0.1144 |     10 KB |
|        AllocateArray |     10 | 7,411.1 ns | 1,954.3 ns | 107.12 ns | 7,303.5 ns | 7,517.7 ns | 0.1221 | 0.1144 |     10 KB |
|    AllocateArrayPool |     10 | 7,272.1 ns | 2,041.8 ns | 111.92 ns | 7,167.1 ns | 7,389.9 ns | 0.1221 | 0.1144 |     10 KB |
