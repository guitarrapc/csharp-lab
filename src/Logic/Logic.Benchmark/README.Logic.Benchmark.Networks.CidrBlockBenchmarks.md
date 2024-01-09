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
| **CidrBlockNewString**      | **1**      |  **59.2151 ns** |  **1.3712 ns** | **0.0752 ns** |  **59.1705 ns** |  **59.3019 ns** |         **-** |
| CidrBlockNewBytes       | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| CidrBlockTryParseString | 1      |  62.4212 ns |  2.7352 ns | 0.1499 ns |  62.2895 ns |  62.5844 ns |         - |
| CidrBlockTryParseBytes  | 1      |   3.0451 ns |  0.3306 ns | 0.0181 ns |   3.0338 ns |   3.0660 ns |         - |
| **CidrBlockNewString**      | **10**     | **603.9461 ns** | **50.3409 ns** | **2.7594 ns** | **602.3440 ns** | **607.1323 ns** |         **-** |
| CidrBlockNewBytes       | 10     |   2.8412 ns |  0.0077 ns | 0.0004 ns |   2.8409 ns |   2.8417 ns |         - |
| CidrBlockTryParseString | 10     | 648.9168 ns |  7.4254 ns | 0.4070 ns | 648.4823 ns | 649.2892 ns |         - |
| CidrBlockTryParseBytes  | 10     |  28.5554 ns |  1.7710 ns | 0.0971 ns |  28.4947 ns |  28.6674 ns |         - |
