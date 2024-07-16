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
| **NewFromCidrString**  | **1**      |  **65.0284 ns** |  **0.9689 ns** | **0.0531 ns** |  **64.9798 ns** |  **65.0851 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  74.2219 ns |  4.8788 ns | 0.2674 ns |  74.0182 ns |  74.5247 ns |         - |
| TryParseCidrBytes  | 1      |   3.0403 ns |  0.1861 ns | 0.0102 ns |   3.0322 ns |   3.0518 ns |         - |
| **NewFromCidrString**  | **3**      | **197.9862 ns** | **12.6082 ns** | **0.6911 ns** | **197.1950 ns** | **198.4719 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.5945 ns |  0.0104 ns | 0.0006 ns |   0.5939 ns |   0.5950 ns |         - |
| TryParseCidrString | 3      | 216.4232 ns |  3.8539 ns | 0.2112 ns | 216.1969 ns | 216.6152 ns |         - |
| TryParseCidrBytes  | 3      |   9.3797 ns |  2.0327 ns | 0.1114 ns |   9.2711 ns |   9.4937 ns |         - |
