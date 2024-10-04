```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **67.4734 ns** | **0.0706 ns** | **0.0039 ns** |  **67.4696 ns** |  **67.4773 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0218 ns | 0.0315 ns | 0.0017 ns |   0.0200 ns |   0.0234 ns |         - |
| TryParseCidrString | 1      |  73.4906 ns | 1.8613 ns | 0.1020 ns |  73.4032 ns |  73.6027 ns |         - |
| TryParseCidrBytes  | 1      |   2.7656 ns | 0.1194 ns | 0.0065 ns |   2.7581 ns |   2.7702 ns |         - |
| **NewFromCidrString**  | **3**      | **202.6159 ns** | **5.4221 ns** | **0.2972 ns** | **202.3564 ns** | **202.9401 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.5753 ns | 0.7715 ns | 0.0423 ns |   0.5502 ns |   0.6242 ns |         - |
| TryParseCidrString | 3      | 211.8329 ns | 8.5455 ns | 0.4684 ns | 211.2993 ns | 212.1761 ns |         - |
| TryParseCidrBytes  | 3      |   9.3050 ns | 0.5427 ns | 0.0297 ns |   9.2721 ns |   9.3300 ns |         - |
