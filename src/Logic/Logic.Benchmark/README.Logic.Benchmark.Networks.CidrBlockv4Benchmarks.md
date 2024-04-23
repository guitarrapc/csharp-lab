```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **69.2370 ns** |  **0.8970 ns** | **0.0492 ns** |  **69.1869 ns** |  **69.2852 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  72.9505 ns | 13.2138 ns | 0.7243 ns |  72.2930 ns |  73.7268 ns |         - |
| TryParseCidrBytes  | 1      |   3.0324 ns |  0.0844 ns | 0.0046 ns |   3.0282 ns |   3.0374 ns |         - |
| **NewFromCidrString**  | **3**      | **198.1335 ns** | **42.1546 ns** | **2.3106 ns** | **196.3259 ns** | **200.7368 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6081 ns |  0.2369 ns | 0.0130 ns |   0.5996 ns |   0.6230 ns |         - |
| TryParseCidrString | 3      | 211.1238 ns |  9.2858 ns | 0.5090 ns | 210.5913 ns | 211.6054 ns |         - |
| TryParseCidrBytes  | 3      |   9.1474 ns |  1.5213 ns | 0.0834 ns |   9.0535 ns |   9.2129 ns |         - |
