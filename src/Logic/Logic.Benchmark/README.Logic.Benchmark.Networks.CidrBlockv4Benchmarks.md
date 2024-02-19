```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error       | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|------------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.2355 ns** |   **4.5381 ns** | **0.2488 ns** |  **65.0624 ns** |  **65.5206 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |   0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  73.6587 ns |   0.7238 ns | 0.0397 ns |  73.6167 ns |  73.6955 ns |         - |
| TryParseCidrBytes  | 1      |   3.0473 ns |   0.3114 ns | 0.0171 ns |   3.0358 ns |   3.0669 ns |         - |
| **NewFromCidrString**  | **10**     | **669.8185 ns** | **178.7914 ns** | **9.8002 ns** | **658.5065 ns** | **675.7440 ns** |         **-** |
| NewFromCirBytes    | 10     |   3.3117 ns |   0.2278 ns | 0.0125 ns |   3.2978 ns |   3.3218 ns |         - |
| TryParseCidrString | 10     | 701.7077 ns |  19.7819 ns | 1.0843 ns | 700.5002 ns | 702.5980 ns |         - |
| TryParseCidrBytes  | 10     |  29.2725 ns |   3.6343 ns | 0.1992 ns |  29.0706 ns |  29.4689 ns |         - |
