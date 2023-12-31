```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | Number | Mean        | Error       | StdDev     | Median      | Min         | Max         | Allocated |
|------------------------ |------- |------------:|------------:|-----------:|------------:|------------:|------------:|----------:|
| **CidrBlockNewString**      | **1**      |  **60.1744 ns** |  **23.5290 ns** |  **1.2897 ns** |  **59.4489 ns** |  **59.4109 ns** |  **61.6635 ns** |         **-** |
| CidrBlockNewBytes       | 1      |   0.0107 ns |   0.2884 ns |  0.0158 ns |   0.0033 ns |   0.0000 ns |   0.0289 ns |         - |
| CidrBlockTryParseString | 1      |  62.6778 ns |   3.4208 ns |  0.1875 ns |  62.6062 ns |  62.5366 ns |  62.8906 ns |         - |
| CidrBlockTryParseBytes  | 1      |   3.0391 ns |   0.0566 ns |  0.0031 ns |   3.0403 ns |   3.0356 ns |   3.0415 ns |         - |
| **CidrBlockNewString**      | **10**     | **606.2662 ns** |   **1.0473 ns** |  **0.0574 ns** | **606.2558 ns** | **606.2147 ns** | **606.3281 ns** |         **-** |
| CidrBlockNewBytes       | 10     |   2.8415 ns |   0.0197 ns |  0.0011 ns |   2.8413 ns |   2.8405 ns |   2.8426 ns |         - |
| CidrBlockTryParseString | 10     | 638.2792 ns | 210.2094 ns | 11.5223 ns | 631.9071 ns | 631.3503 ns | 651.5801 ns |         - |
| CidrBlockTryParseBytes  | 10     |  28.8163 ns |   4.7508 ns |  0.2604 ns |  28.7216 ns |  28.6165 ns |  29.1108 ns |         - |
