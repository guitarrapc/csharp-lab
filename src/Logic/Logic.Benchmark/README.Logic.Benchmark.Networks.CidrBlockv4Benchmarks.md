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
| **NewFromCidrString**  | **1**      |  **64.6391 ns** |  **4.7959 ns** | **0.2629 ns** |  **64.4517 ns** |  **64.9396 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0230 ns |  0.1331 ns | 0.0073 ns |   0.0182 ns |   0.0314 ns |         - |
| TryParseCidrString | 1      |  72.9163 ns |  6.1510 ns | 0.3372 ns |  72.6431 ns |  73.2931 ns |         - |
| TryParseCidrBytes  | 1      |   2.7432 ns |  0.0142 ns | 0.0008 ns |   2.7428 ns |   2.7441 ns |         - |
| **NewFromCidrString**  | **3**      | **225.5170 ns** | **64.5870 ns** | **3.5402 ns** | **223.2825 ns** | **229.5988 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6366 ns |  0.1462 ns | 0.0080 ns |   0.6318 ns |   0.6459 ns |         - |
| TryParseCidrString | 3      | 208.3640 ns |  6.1295 ns | 0.3360 ns | 208.0127 ns | 208.6821 ns |         - |
| TryParseCidrBytes  | 3      |   9.5169 ns |  3.7442 ns | 0.2052 ns |   9.2959 ns |   9.7014 ns |         - |
