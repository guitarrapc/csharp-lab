```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------------ |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **CidrBlockNewString**      | **1**      |  **59.4926 ns** |  **3.1383 ns** | **0.1720 ns** |  **59.3398 ns** |  **59.6789 ns** |         **-** |
| CidrBlockNewBytes       | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| CidrBlockTryParseString | 1      |  63.4903 ns | 33.8461 ns | 1.8552 ns |  62.2349 ns |  65.6212 ns |         - |
| CidrBlockTryParseBytes  | 1      |   3.0348 ns |  0.0398 ns | 0.0022 ns |   3.0327 ns |   3.0370 ns |         - |
| **CidrBlockNewString**      | **10**     | **607.7187 ns** | **34.3462 ns** | **1.8826 ns** | **606.3739 ns** | **609.8703 ns** |         **-** |
| CidrBlockNewBytes       | 10     |   2.8494 ns |  0.3039 ns | 0.0167 ns |   2.8395 ns |   2.8687 ns |         - |
| CidrBlockTryParseString | 10     | 630.5744 ns | 25.4891 ns | 1.3971 ns | 629.1845 ns | 631.9786 ns |         - |
| CidrBlockTryParseBytes  | 10     |  28.5660 ns |  1.5124 ns | 0.0829 ns |  28.5022 ns |  28.6597 ns |         - |
