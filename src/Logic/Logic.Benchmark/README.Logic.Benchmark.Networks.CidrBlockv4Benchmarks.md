```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **69.3071 ns** | **57.1735 ns** | **3.1339 ns** |  **67.4782 ns** |  **72.9257 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  72.5875 ns |  1.4438 ns | 0.0791 ns |  72.5059 ns |  72.6639 ns |         - |
| TryParseCidrBytes  | 1      |   3.0420 ns |  0.1690 ns | 0.0093 ns |   3.0345 ns |   3.0524 ns |         - |
| **NewFromCidrString**  | **3**      | **195.9179 ns** |  **6.3722 ns** | **0.3493 ns** | **195.5827 ns** | **196.2798 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6112 ns |  0.3114 ns | 0.0171 ns |   0.6003 ns |   0.6309 ns |         - |
| TryParseCidrString | 3      | 211.6520 ns | 11.6597 ns | 0.6391 ns | 211.2375 ns | 212.3880 ns |         - |
| TryParseCidrBytes  | 3      |   9.2055 ns |  1.1352 ns | 0.0622 ns |   9.1556 ns |   9.2752 ns |         - |
