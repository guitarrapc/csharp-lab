```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **67.3142 ns** |  **5.8697 ns** | **0.3217 ns** |  **67.0101 ns** |  **67.6511 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  73.8831 ns | 11.1067 ns | 0.6088 ns |  73.5067 ns |  74.5855 ns |         - |
| TryParseCidrBytes  | 1      |   3.0573 ns |  0.3794 ns | 0.0208 ns |   3.0364 ns |   3.0780 ns |         - |
| **NewFromCidrString**  | **3**      | **198.1100 ns** |  **5.2055 ns** | **0.2853 ns** | **197.8544 ns** | **198.4178 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6018 ns |  0.1611 ns | 0.0088 ns |   0.5966 ns |   0.6119 ns |         - |
| TryParseCidrString | 3      | 213.9702 ns |  4.4556 ns | 0.2442 ns | 213.7368 ns | 214.2240 ns |         - |
| TryParseCidrBytes  | 3      |   9.2835 ns |  1.0249 ns | 0.0562 ns |   9.2193 ns |   9.3232 ns |         - |
