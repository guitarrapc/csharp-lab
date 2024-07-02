```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error       | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|------------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **64.9106 ns** |   **0.4791 ns** | **0.0263 ns** |  **64.8951 ns** |  **64.9409 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |   0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  74.5301 ns |  12.1733 ns | 0.6673 ns |  74.1259 ns |  75.3003 ns |         - |
| TryParseCidrBytes  | 1      |   3.0496 ns |   0.2510 ns | 0.0138 ns |   3.0337 ns |   3.0581 ns |         - |
| **NewFromCidrString**  | **3**      | **198.9038 ns** |   **5.7113 ns** | **0.3131 ns** | **198.5621 ns** | **199.1767 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6053 ns |   0.1169 ns | 0.0064 ns |   0.6005 ns |   0.6126 ns |         - |
| TryParseCidrString | 3      | 225.6377 ns | 114.8519 ns | 6.2954 ns | 221.9633 ns | 232.9069 ns |         - |
| TryParseCidrBytes  | 3      |   9.0404 ns |   2.6682 ns | 0.1463 ns |   8.8733 ns |   9.1450 ns |         - |
