```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.0497 ns** |  **2.0235 ns** | **0.1109 ns** |  **64.9333 ns** |  **65.1541 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0206 ns |  0.0642 ns | 0.0035 ns |   0.0172 ns |   0.0242 ns |         - |
| TryParseCidrString | 1      |  84.1352 ns |  3.9982 ns | 0.2192 ns |  83.9503 ns |  84.3773 ns |         - |
| TryParseCidrBytes  | 1      |   2.7679 ns |  0.2707 ns | 0.0148 ns |   2.7580 ns |   2.7849 ns |         - |
| **NewFromCidrString**  | **3**      | **200.0315 ns** |  **6.8353 ns** | **0.3747 ns** | **199.7529 ns** | **200.4575 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6456 ns |  0.1499 ns | 0.0082 ns |   0.6404 ns |   0.6550 ns |         - |
| TryParseCidrString | 3      | 213.6031 ns | 41.1492 ns | 2.2555 ns | 211.6659 ns | 216.0793 ns |         - |
| TryParseCidrBytes  | 3      |   9.3666 ns |  0.6776 ns | 0.0371 ns |   9.3341 ns |   9.4071 ns |         - |
