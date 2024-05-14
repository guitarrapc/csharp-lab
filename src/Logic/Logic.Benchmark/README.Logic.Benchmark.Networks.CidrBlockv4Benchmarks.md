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
| **NewFromCidrString**  | **1**      |  **66.0858 ns** |  **6.1169 ns** | **0.3353 ns** |  **65.8705 ns** |  **66.4721 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  75.6220 ns |  6.7506 ns | 0.3700 ns |  75.1947 ns |  75.8385 ns |         - |
| TryParseCidrBytes  | 1      |   3.0463 ns |  0.4111 ns | 0.0225 ns |   3.0325 ns |   3.0723 ns |         - |
| **NewFromCidrString**  | **3**      | **195.9246 ns** |  **7.6362 ns** | **0.4186 ns** | **195.4458 ns** | **196.2211 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6026 ns |  0.1057 ns | 0.0058 ns |   0.5987 ns |   0.6092 ns |         - |
| TryParseCidrString | 3      | 214.0793 ns | 13.3486 ns | 0.7317 ns | 213.2480 ns | 214.6254 ns |         - |
| TryParseCidrBytes  | 3      |   9.2105 ns |  3.7941 ns | 0.2080 ns |   9.0157 ns |   9.4295 ns |         - |
