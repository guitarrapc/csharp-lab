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
| **AllocateStringStatic** |      **1** |   **757.3 ns** |   **407.1 ns** |  **22.31 ns** |   **732.1 ns** |   **774.6 ns** | **0.0124** | **0.0114** |      **1 KB** |
|       AllocateString |      1 |   733.1 ns |   588.2 ns |  32.24 ns |   698.4 ns |   762.1 ns | 0.0124 | 0.0114 |      1 KB |
|          AllocateLoH |      1 |   718.0 ns |   525.8 ns |  28.82 ns |   701.2 ns |   751.3 ns | 0.0124 | 0.0114 |      1 KB |
|        AllocateArray |      1 |   770.9 ns |   305.0 ns |  16.72 ns |   761.0 ns |   790.2 ns | 0.0124 | 0.0114 |      1 KB |
|    AllocateArrayPool |      1 |   728.9 ns |   118.6 ns |   6.50 ns |   722.2 ns |   735.1 ns | 0.0124 | 0.0114 |      1 KB |
| **AllocateStringStatic** |     **10** | **7,635.2 ns** | **1,736.5 ns** |  **95.19 ns** | **7,566.3 ns** | **7,743.8 ns** | **0.1221** | **0.1144** |     **10 KB** |
|       AllocateString |     10 | 7,305.2 ns |   924.6 ns |  50.68 ns | 7,268.2 ns | 7,363.0 ns | 0.1221 | 0.1144 |     10 KB |
|          AllocateLoH |     10 | 7,299.6 ns |   934.9 ns |  51.24 ns | 7,241.7 ns | 7,339.0 ns | 0.1221 | 0.1144 |     10 KB |
|        AllocateArray |     10 | 7,621.1 ns | 1,946.8 ns | 106.71 ns | 7,524.1 ns | 7,735.4 ns | 0.1221 | 0.1144 |     10 KB |
|    AllocateArrayPool |     10 | 7,526.3 ns | 2,984.9 ns | 163.61 ns | 7,421.6 ns | 7,714.8 ns | 0.1221 | 0.1144 |     10 KB |
