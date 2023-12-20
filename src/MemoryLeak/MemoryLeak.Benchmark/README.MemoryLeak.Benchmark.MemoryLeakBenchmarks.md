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
| **AllocateStringStatic** |      **1** |   **755.0 ns** |   **352.5 ns** |  **19.32 ns** |   **735.0 ns** |   **773.5 ns** | **0.0124** | **0.0114** |      **1 KB** |
|       AllocateString |      1 |   700.5 ns |   193.0 ns |  10.58 ns |   689.1 ns |   710.1 ns | 0.0124 | 0.0114 |      1 KB |
|          AllocateLoH |      1 |   696.0 ns |   351.8 ns |  19.28 ns |   673.8 ns |   708.1 ns | 0.0124 | 0.0114 |      1 KB |
|        AllocateArray |      1 |   714.7 ns |   513.1 ns |  28.12 ns |   696.7 ns |   747.1 ns | 0.0124 | 0.0114 |      1 KB |
|    AllocateArrayPool |      1 |   699.9 ns |   374.0 ns |  20.50 ns |   685.1 ns |   723.3 ns | 0.0124 | 0.0114 |      1 KB |
| **AllocateStringStatic** |     **10** | **7,684.6 ns** | **3,578.0 ns** | **196.12 ns** | **7,477.1 ns** | **7,866.9 ns** | **0.1221** | **0.1144** |     **10 KB** |
|       AllocateString |     10 | 7,206.6 ns | 4,249.9 ns | 232.95 ns | 6,970.6 ns | 7,436.3 ns | 0.1221 | 0.1144 |     10 KB |
|          AllocateLoH |     10 | 6,992.7 ns | 2,649.0 ns | 145.20 ns | 6,897.6 ns | 7,159.8 ns | 0.1221 | 0.1144 |     10 KB |
|        AllocateArray |     10 | 7,361.2 ns | 2,874.8 ns | 157.57 ns | 7,203.7 ns | 7,518.8 ns | 0.1221 | 0.1144 |     10 KB |
|    AllocateArrayPool |     10 | 7,165.3 ns | 1,934.9 ns | 106.06 ns | 7,044.3 ns | 7,242.1 ns | 0.1221 | 0.1144 |     10 KB |
