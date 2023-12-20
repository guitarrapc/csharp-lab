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
| **AllocateStringStatic** |      **1** |   **742.8 ns** |   **221.6 ns** |  **12.15 ns** |   **735.3 ns** |   **756.8 ns** | **0.0124** | **0.0114** |      **1 KB** |
|       AllocateString |      1 |   714.2 ns |   336.3 ns |  18.44 ns |   695.9 ns |   732.8 ns | 0.0124 | 0.0114 |      1 KB |
|          AllocateLoH |      1 |   698.2 ns |   387.6 ns |  21.24 ns |   678.8 ns |   720.9 ns | 0.0124 | 0.0114 |      1 KB |
|        AllocateArray |      1 |   718.5 ns |   507.4 ns |  27.81 ns |   688.9 ns |   744.1 ns | 0.0124 | 0.0114 |      1 KB |
|    AllocateArrayPool |      1 |   714.8 ns |   243.0 ns |  13.32 ns |   699.4 ns |   723.2 ns | 0.0124 | 0.0114 |      1 KB |
| **AllocateStringStatic** |     **10** | **7,567.1 ns** | **3,586.7 ns** | **196.60 ns** | **7,369.7 ns** | **7,762.9 ns** | **0.1221** | **0.1144** |     **10 KB** |
|       AllocateString |     10 | 7,367.5 ns |   993.9 ns |  54.48 ns | 7,305.5 ns | 7,407.8 ns | 0.1221 | 0.1144 |     10 KB |
|          AllocateLoH |     10 | 7,111.8 ns | 1,414.8 ns |  77.55 ns | 7,025.3 ns | 7,175.0 ns | 0.1221 | 0.1144 |     10 KB |
|        AllocateArray |     10 | 7,496.2 ns | 2,306.5 ns | 126.42 ns | 7,356.9 ns | 7,603.6 ns | 0.1221 | 0.1144 |     10 KB |
|    AllocateArrayPool |     10 | 7,270.6 ns | 2,734.0 ns | 149.86 ns | 7,102.8 ns | 7,391.0 ns | 0.1221 | 0.1144 |     10 KB |
