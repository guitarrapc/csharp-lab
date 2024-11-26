```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Median      | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **66.1150 ns** |  **7.5783 ns** | **0.4154 ns** |  **65.9964 ns** |  **65.7718 ns** |  **66.5767 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0083 ns |  0.2613 ns | 0.0143 ns |   0.0000 ns |   0.0000 ns |   0.0248 ns |         - |
| TryParseCidrString | 1      |  73.0705 ns |  0.8696 ns | 0.0477 ns |  73.0714 ns |  73.0224 ns |  73.1177 ns |         - |
| TryParseCidrBytes  | 1      |   2.7455 ns |  0.0344 ns | 0.0019 ns |   2.7462 ns |   2.7434 ns |   2.7470 ns |         - |
| **NewFromCidrString**  | **3**      | **194.6177 ns** | **20.0267 ns** | **1.0977 ns** | **194.0393 ns** | **193.9302 ns** | **195.8837 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6390 ns |  0.0360 ns | 0.0020 ns |   0.6379 ns |   0.6378 ns |   0.6413 ns |         - |
| TryParseCidrString | 3      | 210.4430 ns |  3.9154 ns | 0.2146 ns | 210.4529 ns | 210.2237 ns | 210.6526 ns |         - |
| TryParseCidrBytes  | 3      |   9.3095 ns |  0.7202 ns | 0.0395 ns |   9.3050 ns |   9.2725 ns |   9.3511 ns |         - |
