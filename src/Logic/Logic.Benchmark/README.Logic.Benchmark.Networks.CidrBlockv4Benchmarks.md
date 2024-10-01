```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **67.0590 ns** | **1.1005 ns** | **0.0603 ns** |  **67.0123 ns** |  **67.1271 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0234 ns | 0.0133 ns | 0.0007 ns |   0.0228 ns |   0.0242 ns |         - |
| TryParseCidrString | 1      |  73.6095 ns | 2.6002 ns | 0.1425 ns |  73.4462 ns |  73.7093 ns |         - |
| TryParseCidrBytes  | 1      |   2.7657 ns | 0.1709 ns | 0.0094 ns |   2.7601 ns |   2.7765 ns |         - |
| **NewFromCidrString**  | **3**      | **197.3326 ns** | **6.9432 ns** | **0.3806 ns** | **197.0174 ns** | **197.7554 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6433 ns | 0.0456 ns | 0.0025 ns |   0.6414 ns |   0.6461 ns |         - |
| TryParseCidrString | 3      | 211.8474 ns | 7.2848 ns | 0.3993 ns | 211.4723 ns | 212.2671 ns |         - |
| TryParseCidrBytes  | 3      |   9.3627 ns | 1.5525 ns | 0.0851 ns |   9.3093 ns |   9.4609 ns |         - |
