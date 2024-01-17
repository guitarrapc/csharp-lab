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
| **CidrBlockV4NewString**      | **1**      |  **65.5878 ns** |   **3.6102 ns** | **0.1979 ns** |  **65.4564 ns** |  **65.8154 ns** |         **-** |
| CidrBlockV4NewBytes       | 1      |   0.0000 ns |   0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| CidrBlockV4TryParseString | 1      |  73.9537 ns |   2.3659 ns | 0.1297 ns |  73.8663 ns |  74.1027 ns |         - |
| CidrBlockV4TryParseBytes  | 1      |   3.0379 ns |   0.0260 ns | 0.0014 ns |   3.0365 ns |   3.0393 ns |         - |
| **CidrBlockV4NewString**      | **10**     | **667.0857 ns** | **107.1234 ns** | **5.8718 ns** | **660.4726 ns** | **671.6878 ns** |         **-** |
| CidrBlockV4NewBytes       | 10     |   3.3085 ns |   0.1177 ns | 0.0065 ns |   3.3019 ns |   3.3148 ns |         - |
| CidrBlockV4TryParseString | 10     | 702.1622 ns |  12.3870 ns | 0.6790 ns | 701.4119 ns | 702.7343 ns |         - |
| CidrBlockV4TryParseBytes  | 10     |  28.5475 ns |   1.8460 ns | 0.1012 ns |  28.4888 ns |  28.6644 ns |         - |
