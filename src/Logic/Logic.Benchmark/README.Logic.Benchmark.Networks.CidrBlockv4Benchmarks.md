```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                    | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|-------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **CidrBlockV4NewString**      | **1**      |  **67.1553 ns** |  **5.6334 ns** | **0.3088 ns** |  **66.8998 ns** |  **67.4984 ns** |         **-** |
| CidrBlockV4NewBytes       | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| CidrBlockV4TryParseString | 1      |  73.3095 ns |  2.6731 ns | 0.1465 ns |  73.2204 ns |  73.4786 ns |         - |
| CidrBlockV4TryParseBytes  | 1      |   3.0359 ns |  0.0123 ns | 0.0007 ns |   3.0355 ns |   3.0367 ns |         - |
| **CidrBlockV4NewString**      | **10**     | **665.9348 ns** |  **5.8352 ns** | **0.3198 ns** | **665.6406 ns** | **666.2753 ns** |         **-** |
| CidrBlockV4NewBytes       | 10     |   3.3076 ns |  0.2487 ns | 0.0136 ns |   3.2984 ns |   3.3233 ns |         - |
| CidrBlockV4TryParseString | 10     | 727.2454 ns | 11.8679 ns | 0.6505 ns | 726.5685 ns | 727.8658 ns |         - |
| CidrBlockV4TryParseBytes  | 10     |  28.5291 ns |  0.2635 ns | 0.0144 ns |  28.5126 ns |  28.5398 ns |         - |
