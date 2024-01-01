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
| **CidrBlockNewString**      | **1**      |  **59.6566 ns** |  **7.0318 ns** | **0.3854 ns** |  **59.4025 ns** |  **60.1001 ns** |         **-** |
| CidrBlockNewBytes       | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| CidrBlockTryParseString | 1      |  62.5289 ns |  4.5648 ns | 0.2502 ns |  62.3292 ns |  62.8096 ns |         - |
| CidrBlockTryParseBytes  | 1      |   3.0384 ns |  0.0413 ns | 0.0023 ns |   3.0365 ns |   3.0409 ns |         - |
| **CidrBlockNewString**      | **10**     | **620.8392 ns** |  **1.7112 ns** | **0.0938 ns** | **620.7576 ns** | **620.9417 ns** |         **-** |
| CidrBlockNewBytes       | 10     |   2.8570 ns |  0.4548 ns | 0.0249 ns |   2.8410 ns |   2.8858 ns |         - |
| CidrBlockTryParseString | 10     | 640.1469 ns | 59.7368 ns | 3.2744 ns | 637.9497 ns | 643.9103 ns |         - |
| CidrBlockTryParseBytes  | 10     |  28.6558 ns |  1.5054 ns | 0.0825 ns |  28.6017 ns |  28.7508 ns |         - |
