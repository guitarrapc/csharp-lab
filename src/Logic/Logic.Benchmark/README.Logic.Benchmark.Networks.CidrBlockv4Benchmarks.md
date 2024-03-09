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
| **NewFromCidrString**  | **1**      |  **65.5659 ns** |  **2.5564 ns** | **0.1401 ns** |  **65.4649 ns** |  **65.7259 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  76.8975 ns | 29.2189 ns | 1.6016 ns |  75.8216 ns |  78.7381 ns |         - |
| TryParseCidrBytes  | 1      |   3.0339 ns |  0.0462 ns | 0.0025 ns |   3.0311 ns |   3.0360 ns |         - |
| **NewFromCidrString**  | **3**      | **198.8249 ns** | **10.1147 ns** | **0.5544 ns** | **198.4172 ns** | **199.4562 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6061 ns |  0.1489 ns | 0.0082 ns |   0.5994 ns |   0.6152 ns |         - |
| TryParseCidrString | 3      | 212.0480 ns | 12.2918 ns | 0.6738 ns | 211.5930 ns | 212.8220 ns |         - |
| TryParseCidrBytes  | 3      |   9.0913 ns |  1.3209 ns | 0.0724 ns |   9.0091 ns |   9.1458 ns |         - |
