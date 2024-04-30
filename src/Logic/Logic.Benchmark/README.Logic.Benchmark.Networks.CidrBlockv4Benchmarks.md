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
| **NewFromCidrString**  | **1**      |  **64.7666 ns** |  **0.2727 ns** | **0.0149 ns** |  **64.7560 ns** |  **64.7837 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  73.9046 ns |  2.8088 ns | 0.1540 ns |  73.7552 ns |  74.0628 ns |         - |
| TryParseCidrBytes  | 1      |   3.0429 ns |  0.2405 ns | 0.0132 ns |   3.0349 ns |   3.0582 ns |         - |
| **NewFromCidrString**  | **3**      | **198.3836 ns** | **19.5063 ns** | **1.0692 ns** | **197.5870 ns** | **199.5988 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6002 ns |  0.0136 ns | 0.0007 ns |   0.5994 ns |   0.6008 ns |         - |
| TryParseCidrString | 3      | 215.0292 ns | 45.2403 ns | 2.4798 ns | 212.9087 ns | 217.7559 ns |         - |
| TryParseCidrBytes  | 3      |   9.3714 ns |  0.3372 ns | 0.0185 ns |   9.3540 ns |   9.3908 ns |         - |
