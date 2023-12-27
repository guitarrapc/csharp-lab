```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | Number | Mean          | Error         | StdDev      | Min           | Max           | Allocated |
|------------------------ |------- |--------------:|--------------:|------------:|--------------:|--------------:|----------:|
| **CidrBlockNewString**      | **1**      |    **60.1875 ns** |    **24.5734 ns** |   **1.3469 ns** |    **59.3883 ns** |    **61.7426 ns** |         **-** |
| CidrBlockNewBytes       | 1      |     0.0000 ns |     0.0000 ns |   0.0000 ns |     0.0000 ns |     0.0000 ns |         - |
| CidrBlockTryParseString | 1      |    62.3206 ns |     6.6238 ns |   0.3631 ns |    61.9991 ns |    62.7144 ns |         - |
| CidrBlockTryParseBytes  | 1      |     3.0477 ns |     0.3697 ns |   0.0203 ns |     3.0335 ns |     3.0709 ns |         - |
| **CidrBlockNewString**      | **10**     |   **603.0305 ns** |    **51.0433 ns** |   **2.7979 ns** |   **601.3307 ns** |   **606.2596 ns** |         **-** |
| CidrBlockNewBytes       | 10     |     2.8424 ns |     0.0253 ns |   0.0014 ns |     2.8409 ns |     2.8436 ns |         - |
| CidrBlockTryParseString | 10     |   630.3565 ns |    34.0898 ns |   1.8686 ns |   628.9417 ns |   632.4747 ns |         - |
| CidrBlockTryParseBytes  | 10     |    28.5909 ns |     3.0946 ns |   0.1696 ns |    28.4758 ns |    28.7857 ns |         - |
| **CidrBlockNewString**      | **100**    | **6,013.7832 ns** |   **933.5954 ns** |  **51.1735 ns** | **5,967.9045 ns** | **6,068.9729 ns** |         **-** |
| CidrBlockNewBytes       | 100    |    66.2002 ns |     1.9519 ns |   0.1070 ns |    66.1374 ns |    66.3238 ns |         - |
| CidrBlockTryParseString | 100    | 6,265.7493 ns | 2,046.2540 ns | 112.1621 ns | 6,197.3520 ns | 6,395.1934 ns |         - |
| CidrBlockTryParseBytes  | 100    |   285.4048 ns |     0.6147 ns |   0.0337 ns |   285.3669 ns |   285.4313 ns |         - |
