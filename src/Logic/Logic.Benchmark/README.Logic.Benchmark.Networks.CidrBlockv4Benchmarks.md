```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                    | Number | Mean        | Error       | StdDev    | Min         | Max         | Allocated |
|-------------------------- |------- |------------:|------------:|----------:|------------:|------------:|----------:|
| **CidrBlockV4NewString**      | **1**      |  **65.7425 ns** |   **6.3328 ns** | **0.3471 ns** |  **65.4584 ns** |  **66.1294 ns** |         **-** |
| CidrBlockV4NewBytes       | 1      |   0.0000 ns |   0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| CidrBlockV4TryParseString | 1      |  73.8348 ns |   3.5793 ns | 0.1962 ns |  73.6182 ns |  74.0007 ns |         - |
| CidrBlockV4TryParseBytes  | 1      |   3.0593 ns |   0.8039 ns | 0.0441 ns |   3.0338 ns |   3.1102 ns |         - |
| **CidrBlockV4NewString**      | **10**     | **661.8607 ns** |  **36.5382 ns** | **2.0028 ns** | **660.4737 ns** | **664.1568 ns** |         **-** |
| CidrBlockV4NewBytes       | 10     |   3.3179 ns |   0.2880 ns | 0.0158 ns |   3.3034 ns |   3.3347 ns |         - |
| CidrBlockV4TryParseString | 10     | 711.1774 ns | 159.2376 ns | 8.7284 ns | 704.7112 ns | 721.1057 ns |         - |
| CidrBlockV4TryParseBytes  | 10     |  28.1966 ns |   0.6119 ns | 0.0335 ns |  28.1579 ns |  28.2160 ns |         - |
