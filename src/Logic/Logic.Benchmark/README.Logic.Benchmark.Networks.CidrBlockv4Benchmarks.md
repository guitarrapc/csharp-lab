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
| **NewFromCidrString**  | **1**      |  **64.8124 ns** |  **2.0998 ns** | **0.1151 ns** |  **64.7311 ns** |  **64.9441 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  73.4973 ns |  3.6555 ns | 0.2004 ns |  73.2665 ns |  73.6266 ns |         - |
| TryParseCidrBytes  | 1      |   3.0410 ns |  0.2495 ns | 0.0137 ns |   3.0319 ns |   3.0567 ns |         - |
| **NewFromCidrString**  | **3**      | **194.9742 ns** |  **7.0106 ns** | **0.3843 ns** | **194.5304 ns** | **195.1971 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6055 ns |  0.1173 ns | 0.0064 ns |   0.6006 ns |   0.6128 ns |         - |
| TryParseCidrString | 3      | 212.4154 ns | 38.1878 ns | 2.0932 ns | 211.0454 ns | 214.8249 ns |         - |
| TryParseCidrBytes  | 3      |   9.2506 ns |  1.6192 ns | 0.0888 ns |   9.1876 ns |   9.3521 ns |         - |
