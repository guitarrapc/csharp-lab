```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Median      | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.2589 ns** |  **1.1457 ns** | **0.0628 ns** |  **65.2939 ns** |  **65.1864 ns** |  **65.2964 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0157 ns |  0.4954 ns | 0.0272 ns |   0.0000 ns |   0.0000 ns |   0.0470 ns |         - |
| TryParseCidrString | 1      |  73.8145 ns |  0.1931 ns | 0.0106 ns |  73.8156 ns |  73.8034 ns |  73.8245 ns |         - |
| TryParseCidrBytes  | 1      |   3.0346 ns |  0.0253 ns | 0.0014 ns |   3.0338 ns |   3.0337 ns |   3.0362 ns |         - |
| **NewFromCidrString**  | **3**      | **197.6462 ns** | **18.0980 ns** | **0.9920 ns** | **197.1566 ns** | **196.9941 ns** | **198.7878 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6045 ns |  0.0996 ns | 0.0055 ns |   0.6026 ns |   0.6002 ns |   0.6106 ns |         - |
| TryParseCidrString | 3      | 216.6803 ns | 61.4030 ns | 3.3657 ns | 218.5880 ns | 212.7941 ns | 218.6588 ns |         - |
| TryParseCidrBytes  | 3      |   9.2430 ns |  6.4855 ns | 0.3555 ns |   9.0406 ns |   9.0349 ns |   9.6535 ns |         - |
