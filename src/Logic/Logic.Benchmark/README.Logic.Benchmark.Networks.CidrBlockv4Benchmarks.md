```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.6572 ns** |  **2.0273 ns** | **0.1111 ns** |  **65.5899 ns** |  **65.7855 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  73.6870 ns |  1.0898 ns | 0.0597 ns |  73.6206 ns |  73.7365 ns |         - |
| TryParseCidrBytes  | 1      |   3.0393 ns |  0.1100 ns | 0.0060 ns |   3.0342 ns |   3.0460 ns |         - |
| **NewFromCidrString**  | **10**     | **659.9096 ns** | **19.3792 ns** | **1.0622 ns** | **659.0656 ns** | **661.1024 ns** |         **-** |
| NewFromCirBytes    | 10     |   3.3004 ns |  0.1283 ns | 0.0070 ns |   3.2940 ns |   3.3079 ns |         - |
| TryParseCidrString | 10     | 701.7779 ns |  7.1768 ns | 0.3934 ns | 701.4637 ns | 702.2191 ns |         - |
| TryParseCidrBytes  | 10     |  28.4993 ns |  0.1873 ns | 0.0103 ns |  28.4875 ns |  28.5056 ns |         - |
