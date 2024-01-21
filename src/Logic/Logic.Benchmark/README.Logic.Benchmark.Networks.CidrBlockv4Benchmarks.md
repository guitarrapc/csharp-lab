```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error         | StdDev     | Min         | Max         | Allocated |
|------------------- |------- |------------:|--------------:|-----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **64.8800 ns** |     **0.8406 ns** |  **0.0461 ns** |  **64.8479 ns** |  **64.9328 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |     0.0000 ns |  0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  73.7497 ns |     1.2645 ns |  0.0693 ns |  73.6929 ns |  73.8269 ns |         - |
| TryParseCidrBytes  | 1      |   3.0418 ns |     0.2074 ns |  0.0114 ns |   3.0347 ns |   3.0549 ns |         - |
| **NewFromCidrString**  | **10**     | **868.5872 ns** | **1,352.5552 ns** | **74.1381 ns** | **823.9310 ns** | **954.1674 ns** |         **-** |
| NewFromCirBytes    | 10     |   3.3107 ns |     0.2688 ns |  0.0147 ns |   3.2993 ns |   3.3273 ns |         - |
| TryParseCidrString | 10     | 702.1507 ns |    12.2041 ns |  0.6689 ns | 701.7565 ns | 702.9231 ns |         - |
| TryParseCidrBytes  | 10     |  28.4731 ns |     0.0721 ns |  0.0040 ns |  28.4698 ns |  28.4775 ns |         - |
