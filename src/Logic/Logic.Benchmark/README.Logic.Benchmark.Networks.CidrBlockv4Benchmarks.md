```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **67.6397 ns** |  **1.0967 ns** | **0.0601 ns** |  **67.5735 ns** |  **67.6910 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0218 ns |  0.0570 ns | 0.0031 ns |   0.0190 ns |   0.0252 ns |         - |
| TryParseCidrString | 1      |  72.7873 ns |  2.8842 ns | 0.1581 ns |  72.6685 ns |  72.9667 ns |         - |
| TryParseCidrBytes  | 1      |   2.7483 ns |  0.0353 ns | 0.0019 ns |   2.7472 ns |   2.7505 ns |         - |
| **NewFromCidrString**  | **3**      | **199.3417 ns** | **15.0126 ns** | **0.8229 ns** | **198.8596 ns** | **200.2918 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.8458 ns |  1.6381 ns | 0.0898 ns |   0.7603 ns |   0.9393 ns |         - |
| TryParseCidrString | 3      | 211.0395 ns | 19.1034 ns | 1.0471 ns | 210.2733 ns | 212.2326 ns |         - |
| TryParseCidrBytes  | 3      |   9.2380 ns |  1.8737 ns | 0.1027 ns |   9.1227 ns |   9.3197 ns |         - |
