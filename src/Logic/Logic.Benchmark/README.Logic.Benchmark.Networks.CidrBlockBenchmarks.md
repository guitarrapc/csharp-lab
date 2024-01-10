```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------------ |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **CidrBlockNewString**      | **1**      |  **60.3101 ns** |  **6.6950 ns** | **0.3670 ns** |  **60.0815 ns** |  **60.7334 ns** |         **-** |
| CidrBlockNewBytes       | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| CidrBlockTryParseString | 1      |  62.4049 ns |  1.6879 ns | 0.0925 ns |  62.3336 ns |  62.5095 ns |         - |
| CidrBlockTryParseBytes  | 1      |   3.0425 ns |  0.1199 ns | 0.0066 ns |   3.0352 ns |   3.0479 ns |         - |
| **CidrBlockNewString**      | **10**     | **610.9738 ns** | **20.8454 ns** | **1.1426 ns** | **609.7775 ns** | **612.0538 ns** |         **-** |
| CidrBlockNewBytes       | 10     |   3.3045 ns |  0.2552 ns | 0.0140 ns |   3.2939 ns |   3.3203 ns |         - |
| CidrBlockTryParseString | 10     | 630.4055 ns | 14.5289 ns | 0.7964 ns | 629.4889 ns | 630.9274 ns |         - |
| CidrBlockTryParseBytes  | 10     |  28.6762 ns |  0.9913 ns | 0.0543 ns |  28.6200 ns |  28.7284 ns |         - |
