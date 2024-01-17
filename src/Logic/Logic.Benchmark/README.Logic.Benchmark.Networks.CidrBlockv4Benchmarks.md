```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                    | Number | Mean        | Error      | StdDev    | Median      | Min         | Max         | Allocated |
|-------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|------------:|----------:|
| **CidrBlockV4NewString**      | **1**      |  **65.8129 ns** | **11.9498 ns** | **0.6550 ns** |  **66.0945 ns** |  **65.0642 ns** |  **66.2800 ns** |         **-** |
| CidrBlockV4NewBytes       | 1      |   0.0018 ns |  0.0576 ns | 0.0032 ns |   0.0000 ns |   0.0000 ns |   0.0055 ns |         - |
| CidrBlockV4TryParseString | 1      |  73.4510 ns |  0.4489 ns | 0.0246 ns |  73.4608 ns |  73.4230 ns |  73.4691 ns |         - |
| CidrBlockV4TryParseBytes  | 1      |   3.0369 ns |  0.1499 ns | 0.0082 ns |   3.0326 ns |   3.0318 ns |   3.0464 ns |         - |
| **CidrBlockV4NewString**      | **10**     | **660.2685 ns** | **10.5346 ns** | **0.5774 ns** | **660.2969 ns** | **659.6774 ns** | **660.8312 ns** |         **-** |
| CidrBlockV4NewBytes       | 10     |   3.3014 ns |  0.0982 ns | 0.0054 ns |   3.3006 ns |   3.2965 ns |   3.3071 ns |         - |
| CidrBlockV4TryParseString | 10     | 702.2837 ns | 14.2540 ns | 0.7813 ns | 702.3620 ns | 701.4662 ns | 703.0229 ns |         - |
| CidrBlockV4TryParseBytes  | 10     |  28.7290 ns |  2.0329 ns | 0.1114 ns |  28.7426 ns |  28.6114 ns |  28.8330 ns |         - |
