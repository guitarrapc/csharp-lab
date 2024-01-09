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
| **CidrBlockNewString**      | **1**      |  **59.6533 ns** | **21.7484 ns** | **1.1921 ns** |  **58.9536 ns** |  **61.0297 ns** |         **-** |
| CidrBlockNewBytes       | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| CidrBlockTryParseString | 1      |  62.3626 ns |  0.2081 ns | 0.0114 ns |  62.3512 ns |  62.3740 ns |         - |
| CidrBlockTryParseBytes  | 1      |   3.0540 ns |  0.3462 ns | 0.0190 ns |   3.0330 ns |   3.0699 ns |         - |
| **CidrBlockNewString**      | **10**     | **607.4024 ns** |  **4.9494 ns** | **0.2713 ns** | **607.1463 ns** | **607.6867 ns** |         **-** |
| CidrBlockNewBytes       | 10     |   2.8465 ns |  0.0945 ns | 0.0052 ns |   2.8406 ns |   2.8502 ns |         - |
| CidrBlockTryParseString | 10     | 631.5547 ns | 10.8736 ns | 0.5960 ns | 630.8929 ns | 632.0491 ns |         - |
| CidrBlockTryParseBytes  | 10     |  28.7014 ns |  2.8099 ns | 0.1540 ns |  28.6055 ns |  28.8791 ns |         - |
