```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error       | StdDev     | Min         | Max         | Allocated |
|------------------- |------- |------------:|------------:|-----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **64.9797 ns** |   **2.3656 ns** |  **0.1297 ns** |  **64.8780 ns** |  **65.1257 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |   0.0000 ns |  0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  73.9388 ns |   5.5877 ns |  0.3063 ns |  73.7213 ns |  74.2891 ns |         - |
| TryParseCidrBytes  | 1      |   3.0377 ns |   0.2060 ns |  0.0113 ns |   3.0301 ns |   3.0507 ns |         - |
| **NewFromCidrString**  | **10**     | **668.3953 ns** | **208.9400 ns** | **11.4527 ns** | **660.3011 ns** | **681.4993 ns** |         **-** |
| NewFromCirBytes    | 10     |   3.3060 ns |   0.0757 ns |  0.0042 ns |   3.3013 ns |   3.3093 ns |         - |
| TryParseCidrString | 10     | 695.7818 ns |  36.5709 ns |  2.0046 ns | 694.0629 ns | 697.9838 ns |         - |
| TryParseCidrBytes  | 10     |  28.7374 ns |   3.6212 ns |  0.1985 ns |  28.5922 ns |  28.9636 ns |         - |
