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
| **NewFromCidrString**  | **1**      |  **66.2581 ns** | **6.2214 ns** | **0.3410 ns** |  **65.9147 ns** |  **66.5967 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0223 ns | 0.0216 ns | 0.0012 ns |   0.0210 ns |   0.0233 ns |         - |
| TryParseCidrString | 1      |  72.2752 ns | 1.5504 ns | 0.0850 ns |  72.2182 ns |  72.3729 ns |         - |
| TryParseCidrBytes  | 1      |   3.2485 ns | 0.1756 ns | 0.0096 ns |   3.2399 ns |   3.2589 ns |         - |
| **NewFromCidrString**  | **3**      | **199.7635 ns** | **1.7537 ns** | **0.0961 ns** | **199.6885 ns** | **199.8719 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6423 ns | 0.1303 ns | 0.0071 ns |   0.6370 ns |   0.6504 ns |         - |
| TryParseCidrString | 3      | 208.9524 ns | 6.7060 ns | 0.3676 ns | 208.6354 ns | 209.3553 ns |         - |
| TryParseCidrBytes  | 3      |   9.2713 ns | 1.0364 ns | 0.0568 ns |   9.2304 ns |   9.3361 ns |         - |
