```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **67.5083 ns** | **1.8407 ns** | **0.1009 ns** |  **67.4180 ns** |  **67.6172 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0208 ns | 0.0344 ns | 0.0019 ns |   0.0194 ns |   0.0229 ns |         - |
| TryParseCidrString | 1      |  72.5804 ns | 6.2069 ns | 0.3402 ns |  72.3588 ns |  72.9721 ns |         - |
| TryParseCidrBytes  | 1      |   2.7483 ns | 0.0271 ns | 0.0015 ns |   2.7472 ns |   2.7500 ns |         - |
| **NewFromCidrString**  | **3**      | **198.2098 ns** | **1.4992 ns** | **0.0822 ns** | **198.1184 ns** | **198.2776 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6413 ns | 0.0626 ns | 0.0034 ns |   0.6374 ns |   0.6440 ns |         - |
| TryParseCidrString | 3      | 211.1410 ns | 3.6511 ns | 0.2001 ns | 211.0172 ns | 211.3719 ns |         - |
| TryParseCidrBytes  | 3      |   9.2120 ns | 0.6252 ns | 0.0343 ns |   9.1731 ns |   9.2377 ns |         - |
