```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.2598 ns** |  **1.3027 ns** | **0.0714 ns** |  **65.1942 ns** |  **65.3358 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0197 ns |  0.0274 ns | 0.0015 ns |   0.0183 ns |   0.0213 ns |         - |
| TryParseCidrString | 1      |  72.6664 ns |  3.5361 ns | 0.1938 ns |  72.5503 ns |  72.8901 ns |         - |
| TryParseCidrBytes  | 1      |   2.7519 ns |  0.2494 ns | 0.0137 ns |   2.7431 ns |   2.7677 ns |         - |
| **NewFromCidrString**  | **3**      | **197.4207 ns** | **10.6945 ns** | **0.5862 ns** | **197.0179 ns** | **198.0932 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.9050 ns |  1.5418 ns | 0.0845 ns |   0.8075 ns |   0.9580 ns |         - |
| TryParseCidrString | 3      | 210.1881 ns |  6.1440 ns | 0.3368 ns | 209.9635 ns | 210.5753 ns |         - |
| TryParseCidrBytes  | 3      |   9.2769 ns |  1.2799 ns | 0.0702 ns |   9.2293 ns |   9.3574 ns |         - |
