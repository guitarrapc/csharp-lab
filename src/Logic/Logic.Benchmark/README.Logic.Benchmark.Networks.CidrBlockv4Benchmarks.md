```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.5451 ns** |  **1.0261 ns** | **0.0562 ns** |  **65.5104 ns** |  **65.6100 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0118 ns |  0.0198 ns | 0.0011 ns |   0.0107 ns |   0.0128 ns |         - |
| TryParseCidrString | 1      |  72.6144 ns |  7.9713 ns | 0.4369 ns |  72.1119 ns |  72.9044 ns |         - |
| TryParseCidrBytes  | 1      |   2.7468 ns |  0.0199 ns | 0.0011 ns |   2.7460 ns |   2.7480 ns |         - |
| **NewFromCidrString**  | **3**      | **197.2380 ns** | **19.1168 ns** | **1.0479 ns** | **196.5417 ns** | **198.4431 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6389 ns |  0.0285 ns | 0.0016 ns |   0.6380 ns |   0.6407 ns |         - |
| TryParseCidrString | 3      | 209.7791 ns |  3.3239 ns | 0.1822 ns | 209.6019 ns | 209.9659 ns |         - |
| TryParseCidrBytes  | 3      |   9.3569 ns |  0.8388 ns | 0.0460 ns |   9.3038 ns |   9.3847 ns |         - |
