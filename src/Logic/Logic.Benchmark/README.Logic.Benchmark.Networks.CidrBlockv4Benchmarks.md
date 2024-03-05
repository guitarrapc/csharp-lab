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
| **NewFromCidrString**  | **1**      |  **65.3608 ns** |  **3.5652 ns** | **0.1954 ns** |  **65.2412 ns** |  **65.5863 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  73.5441 ns |  2.7054 ns | 0.1483 ns |  73.4534 ns |  73.7153 ns |         - |
| TryParseCidrBytes  | 1      |   3.0453 ns |  0.2028 ns | 0.0111 ns |   3.0352 ns |   3.0572 ns |         - |
| **NewFromCidrString**  | **10**     | **666.1529 ns** |  **3.2518 ns** | **0.1782 ns** | **665.9482 ns** | **666.2738 ns** |         **-** |
| NewFromCirBytes    | 10     |   3.3029 ns |  0.2658 ns | 0.0146 ns |   3.2932 ns |   3.3197 ns |         - |
| TryParseCidrString | 10     | 697.3503 ns | 26.4859 ns | 1.4518 ns | 695.6983 ns | 698.4232 ns |         - |
| TryParseCidrBytes  | 10     |  28.5622 ns |  1.7790 ns | 0.0975 ns |  28.4771 ns |  28.6686 ns |         - |
