```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.9045 ns** | **7.2509 ns** | **0.3974 ns** |  **65.6322 ns** |  **66.3606 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0220 ns | 0.0006 ns | 0.0000 ns |   0.0219 ns |   0.0220 ns |         - |
| TryParseCidrString | 1      |  72.5790 ns | 0.2118 ns | 0.0116 ns |  72.5658 ns |  72.5876 ns |         - |
| TryParseCidrBytes  | 1      |   2.7509 ns | 0.0869 ns | 0.0048 ns |   2.7454 ns |   2.7537 ns |         - |
| **NewFromCidrString**  | **3**      | **194.6250 ns** | **4.1489 ns** | **0.2274 ns** | **194.4652 ns** | **194.8853 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6419 ns | 0.1102 ns | 0.0060 ns |   0.6382 ns |   0.6489 ns |         - |
| TryParseCidrString | 3      | 207.6117 ns | 4.5882 ns | 0.2515 ns | 207.3251 ns | 207.7955 ns |         - |
| TryParseCidrBytes  | 3      |   9.2411 ns | 1.8975 ns | 0.1040 ns |   9.1293 ns |   9.3351 ns |         - |
