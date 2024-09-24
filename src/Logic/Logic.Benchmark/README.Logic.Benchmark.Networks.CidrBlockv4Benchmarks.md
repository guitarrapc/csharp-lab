```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.6729 ns** | **1.4726 ns** | **0.0807 ns** |  **65.5857 ns** |  **65.7449 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0245 ns | 0.0539 ns | 0.0030 ns |   0.0211 ns |   0.0264 ns |         - |
| TryParseCidrString | 1      |  72.9741 ns | 2.5980 ns | 0.1424 ns |  72.8138 ns |  73.0861 ns |         - |
| TryParseCidrBytes  | 1      |   2.4617 ns | 0.2179 ns | 0.0119 ns |   2.4529 ns |   2.4753 ns |         - |
| **NewFromCidrString**  | **3**      | **197.7630 ns** | **4.1304 ns** | **0.2264 ns** | **197.5017 ns** | **197.9006 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6457 ns | 0.0517 ns | 0.0028 ns |   0.6428 ns |   0.6484 ns |         - |
| TryParseCidrString | 3      | 211.4734 ns | 5.3130 ns | 0.2912 ns | 211.2368 ns | 211.7986 ns |         - |
| TryParseCidrBytes  | 3      |   9.3940 ns | 0.9109 ns | 0.0499 ns |   9.3435 ns |   9.4433 ns |         - |
