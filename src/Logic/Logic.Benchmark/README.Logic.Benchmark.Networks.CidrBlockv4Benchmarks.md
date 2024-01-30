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
| **NewFromCidrString**  | **1**      |  **64.7829 ns** |  **3.6470 ns** | **0.1999 ns** |  **64.6156 ns** |  **65.0043 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  73.8592 ns |  7.1835 ns | 0.3938 ns |  73.6238 ns |  74.3138 ns |         - |
| TryParseCidrBytes  | 1      |   3.0362 ns |  0.0112 ns | 0.0006 ns |   3.0358 ns |   3.0369 ns |         - |
| **NewFromCidrString**  | **10**     | **667.0158 ns** |  **7.9113 ns** | **0.4336 ns** | **666.6164 ns** | **667.4771 ns** |         **-** |
| NewFromCirBytes    | 10     |   3.3051 ns |  0.0890 ns | 0.0049 ns |   3.2997 ns |   3.3092 ns |         - |
| TryParseCidrString | 10     | 703.3723 ns | 14.7086 ns | 0.8062 ns | 702.6900 ns | 704.2619 ns |         - |
| TryParseCidrBytes  | 10     |  28.7520 ns |  0.9196 ns | 0.0504 ns |  28.7056 ns |  28.8056 ns |         - |
