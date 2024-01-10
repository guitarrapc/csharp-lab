```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                    | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|-------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **CidrBlockV4NewString**      | **1**      |  **66.7563 ns** | **41.3464 ns** | **2.2663 ns** |  **65.3674 ns** |  **69.3716 ns** |         **-** |
| CidrBlockV4NewBytes       | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| CidrBlockV4TryParseString | 1      |  73.7863 ns |  8.9971 ns | 0.4932 ns |  73.4839 ns |  74.3554 ns |         - |
| CidrBlockV4TryParseBytes  | 1      |   3.0297 ns |  0.0481 ns | 0.0026 ns |   3.0276 ns |   3.0326 ns |         - |
| **CidrBlockV4NewString**      | **10**     | **656.9599 ns** |  **0.3609 ns** | **0.0198 ns** | **656.9399 ns** | **656.9794 ns** |         **-** |
| CidrBlockV4NewBytes       | 10     |   3.3166 ns |  0.2526 ns | 0.0138 ns |   3.3009 ns |   3.3272 ns |         - |
| CidrBlockV4TryParseString | 10     | 716.9335 ns | 21.9970 ns | 1.2057 ns | 715.5425 ns | 717.6804 ns |         - |
| CidrBlockV4TryParseBytes  | 10     |  28.5488 ns |  1.7754 ns | 0.0973 ns |  28.4887 ns |  28.6610 ns |         - |
