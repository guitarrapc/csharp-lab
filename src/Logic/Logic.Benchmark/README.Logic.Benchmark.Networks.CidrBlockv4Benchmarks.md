```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Median      | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.0928 ns** |  **0.6069 ns** | **0.0333 ns** |  **65.1068 ns** |  **65.0549 ns** |  **65.1169 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0028 ns |  0.0876 ns | 0.0048 ns |   0.0000 ns |   0.0000 ns |   0.0083 ns |         - |
| TryParseCidrString | 1      |  73.8593 ns |  5.0620 ns | 0.2775 ns |  73.7319 ns |  73.6685 ns |  74.1776 ns |         - |
| TryParseCidrBytes  | 1      |   3.0554 ns |  0.3256 ns | 0.0178 ns |   3.0584 ns |   3.0362 ns |   3.0715 ns |         - |
| **NewFromCidrString**  | **3**      | **198.8926 ns** | **10.8282 ns** | **0.5935 ns** | **198.7765 ns** | **198.3656 ns** | **199.5355 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6073 ns |  0.2097 ns | 0.0115 ns |   0.6025 ns |   0.5991 ns |   0.6205 ns |         - |
| TryParseCidrString | 3      | 215.7451 ns | 11.7918 ns | 0.6463 ns | 215.5980 ns | 215.1849 ns | 216.4523 ns |         - |
| TryParseCidrBytes  | 3      |   9.1646 ns |  0.8097 ns | 0.0444 ns |   9.1601 ns |   9.1226 ns |   9.2110 ns |         - |
