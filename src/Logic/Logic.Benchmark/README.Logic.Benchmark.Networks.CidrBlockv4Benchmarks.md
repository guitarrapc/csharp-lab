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
| **NewFromCidrString**  | **1**      |  **64.9873 ns** |  **0.5211 ns** | **0.0286 ns** |  **64.9569 ns** |  **65.0135 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  73.9238 ns |  0.4453 ns | 0.0244 ns |  73.8961 ns |  73.9422 ns |         - |
| TryParseCidrBytes  | 1      |   3.0946 ns |  1.8046 ns | 0.0989 ns |   3.0319 ns |   3.2087 ns |         - |
| **NewFromCidrString**  | **3**      | **199.2819 ns** | **49.3455 ns** | **2.7048 ns** | **197.5797 ns** | **202.4007 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6031 ns |  0.0658 ns | 0.0036 ns |   0.6002 ns |   0.6072 ns |         - |
| TryParseCidrString | 3      | 212.5643 ns |  1.5406 ns | 0.0844 ns | 212.4795 ns | 212.6484 ns |         - |
| TryParseCidrBytes  | 3      |   9.1225 ns |  0.5786 ns | 0.0317 ns |   9.0946 ns |   9.1570 ns |         - |
