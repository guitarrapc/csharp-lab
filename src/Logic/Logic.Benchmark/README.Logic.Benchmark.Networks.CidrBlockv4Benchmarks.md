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
| **NewFromCidrString**  | **1**      |  **64.7108 ns** |  **7.0936 ns** | **0.3888 ns** |  **64.4666 ns** |  **65.1592 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  73.5554 ns |  1.5384 ns | 0.0843 ns |  73.4622 ns |  73.6266 ns |         - |
| TryParseCidrBytes  | 1      |   3.0399 ns |  0.2518 ns | 0.0138 ns |   3.0307 ns |   3.0558 ns |         - |
| **NewFromCidrString**  | **3**      | **197.3849 ns** | **27.9193 ns** | **1.5303 ns** | **196.2813 ns** | **199.1319 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6002 ns |  0.0240 ns | 0.0013 ns |   0.5988 ns |   0.6014 ns |         - |
| TryParseCidrString | 3      | 213.2402 ns |  4.3741 ns | 0.2398 ns | 213.0939 ns | 213.5169 ns |         - |
| TryParseCidrBytes  | 3      |   9.1859 ns |  1.3106 ns | 0.0718 ns |   9.1276 ns |   9.2662 ns |         - |
