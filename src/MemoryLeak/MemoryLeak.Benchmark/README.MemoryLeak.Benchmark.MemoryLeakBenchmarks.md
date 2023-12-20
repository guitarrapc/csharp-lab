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
| **AllocateStringStatic** |      **1** |   **745.1 ns** |   **341.6 ns** |  **18.72 ns** |   **729.2 ns** |   **765.8 ns** | **0.0124** | **0.0114** |      **1 KB** |
|       AllocateString |      1 |   716.2 ns |   541.2 ns |  29.66 ns |   690.6 ns |   748.7 ns | 0.0124 | 0.0114 |      1 KB |
|          AllocateLoH |      1 |   694.4 ns |   544.6 ns |  29.85 ns |   671.2 ns |   728.1 ns | 0.0124 | 0.0114 |      1 KB |
|        AllocateArray |      1 |   724.6 ns |   330.7 ns |  18.12 ns |   704.7 ns |   740.1 ns | 0.0124 | 0.0114 |      1 KB |
|    AllocateArrayPool |      1 |   688.4 ns |   411.5 ns |  22.55 ns |   673.5 ns |   714.3 ns | 0.0124 | 0.0114 |      1 KB |
| **AllocateStringStatic** |     **10** | **7,473.2 ns** | **2,821.0 ns** | **154.63 ns** | **7,309.3 ns** | **7,616.6 ns** | **0.1221** | **0.1144** |     **10 KB** |
|       AllocateString |     10 | 7,271.1 ns | 1,794.2 ns |  98.35 ns | 7,206.4 ns | 7,384.3 ns | 0.1221 | 0.1144 |     10 KB |
|          AllocateLoH |     10 | 7,081.2 ns | 2,902.8 ns | 159.11 ns | 6,953.9 ns | 7,259.6 ns | 0.1221 | 0.1144 |     10 KB |
|        AllocateArray |     10 | 7,456.3 ns | 2,088.5 ns | 114.48 ns | 7,385.1 ns | 7,588.4 ns | 0.1221 | 0.1144 |     10 KB |
|    AllocateArrayPool |     10 | 7,471.4 ns | 1,502.9 ns |  82.38 ns | 7,394.6 ns | 7,558.4 ns | 0.1221 | 0.1144 |     10 KB |
