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
| **CidrBlockV4NewString**      | **1**      |  **67.0325 ns** | **16.3052 ns** | **0.8937 ns** |  **66.0010 ns** |  **67.5764 ns** |         **-** |
| CidrBlockV4NewBytes       | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| CidrBlockV4TryParseString | 1      |  73.4997 ns |  0.7169 ns | 0.0393 ns |  73.4622 ns |  73.5405 ns |         - |
| CidrBlockV4TryParseBytes  | 1      |   3.0366 ns |  0.0464 ns | 0.0025 ns |   3.0350 ns |   3.0395 ns |         - |
| **CidrBlockV4NewString**      | **10**     | **668.0464 ns** | **49.9826 ns** | **2.7397 ns** | **666.4503 ns** | **671.2099 ns** |         **-** |
| CidrBlockV4NewBytes       | 10     |   3.3017 ns |  0.0503 ns | 0.0028 ns |   3.2998 ns |   3.3049 ns |         - |
| CidrBlockV4TryParseString | 10     | 702.7971 ns |  5.5900 ns | 0.3064 ns | 702.5546 ns | 703.1414 ns |         - |
| CidrBlockV4TryParseBytes  | 10     |  28.7692 ns |  0.6552 ns | 0.0359 ns |  28.7277 ns |  28.7915 ns |         - |
