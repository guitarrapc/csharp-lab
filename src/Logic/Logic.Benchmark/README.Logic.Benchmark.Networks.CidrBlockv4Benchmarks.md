```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error       | StdDev     | Median      | Min         | Max         | Allocated |
|------------------- |------- |------------:|------------:|-----------:|------------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **64.7914 ns** |   **1.7283 ns** |  **0.0947 ns** |  **64.7467 ns** |  **64.7272 ns** |  **64.9002 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0032 ns |   0.1003 ns |  0.0055 ns |   0.0000 ns |   0.0000 ns |   0.0095 ns |         - |
| TryParseCidrString | 1      |  74.3111 ns |   5.7315 ns |  0.3142 ns |  74.1756 ns |  74.0875 ns |  74.6703 ns |         - |
| TryParseCidrBytes  | 1      |   3.0492 ns |   0.3932 ns |  0.0216 ns |   3.0395 ns |   3.0341 ns |   3.0738 ns |         - |
| **NewFromCidrString**  | **10**     | **662.6322 ns** |  **47.5746 ns** |  **2.6077 ns** | **661.1412 ns** | **661.1120 ns** | **665.6433 ns** |         **-** |
| NewFromCirBytes    | 10     |   3.3012 ns |   0.0690 ns |  0.0038 ns |   3.3013 ns |   3.2974 ns |   3.3050 ns |         - |
| TryParseCidrString | 10     | 711.6416 ns | 394.3324 ns | 21.6147 ns | 699.2223 ns | 699.1025 ns | 736.6000 ns |         - |
| TryParseCidrBytes  | 10     |  28.6198 ns |   3.4131 ns |  0.1871 ns |  28.5344 ns |  28.4907 ns |  28.8344 ns |         - |
