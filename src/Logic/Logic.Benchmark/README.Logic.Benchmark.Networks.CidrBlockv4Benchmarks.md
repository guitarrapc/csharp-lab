```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error       | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|------------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.2349 ns** |   **3.3134 ns** | **0.1816 ns** |  **65.0368 ns** |  **65.3936 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |   0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  73.8502 ns |   4.4001 ns | 0.2412 ns |  73.6131 ns |  74.0953 ns |         - |
| TryParseCidrBytes  | 1      |   3.0457 ns |   0.3882 ns | 0.0213 ns |   3.0327 ns |   3.0703 ns |         - |
| **NewFromCidrString**  | **10**     | **669.7565 ns** | **106.0701 ns** | **5.8141 ns** | **664.5774 ns** | **676.0455 ns** |         **-** |
| NewFromCirBytes    | 10     |   3.3015 ns |   0.0462 ns | 0.0025 ns |   3.2987 ns |   3.3037 ns |         - |
| TryParseCidrString | 10     | 704.1013 ns |  54.1101 ns | 2.9660 ns | 702.3544 ns | 707.5258 ns |         - |
| TryParseCidrBytes  | 10     |  28.5530 ns |   2.1547 ns | 0.1181 ns |  28.4721 ns |  28.6886 ns |         - |
