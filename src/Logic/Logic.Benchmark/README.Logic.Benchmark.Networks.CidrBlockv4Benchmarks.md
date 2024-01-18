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
| **CidrBlockV4NewString**      | **1**      |  **65.1892 ns** |   **1.1096 ns** | **0.0608 ns** |  **65.1474 ns** |  **65.2590 ns** |         **-** |
| CidrBlockV4NewBytes       | 1      |   0.0000 ns |   0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| CidrBlockV4TryParseString | 1      |  73.4933 ns |   0.5990 ns | 0.0328 ns |  73.4702 ns |  73.5309 ns |         - |
| CidrBlockV4TryParseBytes  | 1      |   3.0346 ns |   0.0731 ns | 0.0040 ns |   3.0319 ns |   3.0392 ns |         - |
| **CidrBlockV4NewString**      | **10**     | **658.5294 ns** |   **6.9216 ns** | **0.3794 ns** | **658.2234 ns** | **658.9539 ns** |         **-** |
| CidrBlockV4NewBytes       | 10     |   3.2968 ns |   0.0885 ns | 0.0048 ns |   3.2929 ns |   3.3022 ns |         - |
| CidrBlockV4TryParseString | 10     | 707.5260 ns | 170.6824 ns | 9.3557 ns | 699.5673 ns | 717.8317 ns |         - |
| CidrBlockV4TryParseBytes  | 10     |  28.4669 ns |   1.2851 ns | 0.0704 ns |  28.4103 ns |  28.5458 ns |         - |
