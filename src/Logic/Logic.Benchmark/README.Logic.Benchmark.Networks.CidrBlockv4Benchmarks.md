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
| **NewFromCidrString**  | **1**      |  **65.9172 ns** |  **6.0781 ns** | **0.3332 ns** |  **65.6214 ns** |  **66.2781 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0246 ns |  0.1533 ns | 0.0084 ns |   0.0196 ns |   0.0343 ns |         - |
| TryParseCidrString | 1      |  72.6710 ns |  4.2339 ns | 0.2321 ns |  72.4881 ns |  72.9321 ns |         - |
| TryParseCidrBytes  | 1      |   2.7557 ns |  0.3967 ns | 0.0217 ns |   2.7416 ns |   2.7808 ns |         - |
| **NewFromCidrString**  | **3**      | **196.1095 ns** | **10.9022 ns** | **0.5976 ns** | **195.6334 ns** | **196.7801 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6453 ns |  0.1984 ns | 0.0109 ns |   0.6373 ns |   0.6577 ns |         - |
| TryParseCidrString | 3      | 210.0613 ns | 10.2446 ns | 0.5615 ns | 209.4264 ns | 210.4925 ns |         - |
| TryParseCidrBytes  | 3      |   9.3363 ns |  1.0348 ns | 0.0567 ns |   9.2708 ns |   9.3695 ns |         - |
