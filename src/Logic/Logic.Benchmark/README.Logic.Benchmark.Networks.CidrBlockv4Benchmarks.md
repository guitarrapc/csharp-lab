```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **68.8324 ns** |  **1.4564 ns** | **0.0798 ns** |  **68.7490 ns** |  **68.9081 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  76.8971 ns |  3.3685 ns | 0.1846 ns |  76.6912 ns |  77.0480 ns |         - |
| TryParseCidrBytes  | 1      |   3.0434 ns |  0.2773 ns | 0.0152 ns |   3.0338 ns |   3.0609 ns |         - |
| **NewFromCidrString**  | **10**     | **661.1394 ns** | **42.8389 ns** | **2.3481 ns** | **659.3114 ns** | **663.7877 ns** |         **-** |
| NewFromCirBytes    | 10     |   3.3225 ns |  0.2656 ns | 0.0146 ns |   3.3057 ns |   3.3310 ns |         - |
| TryParseCidrString | 10     | 700.6579 ns |  7.2236 ns | 0.3960 ns | 700.3200 ns | 701.0936 ns |         - |
| TryParseCidrBytes  | 10     |  28.5152 ns |  1.4325 ns | 0.0785 ns |  28.4675 ns |  28.6058 ns |         - |
