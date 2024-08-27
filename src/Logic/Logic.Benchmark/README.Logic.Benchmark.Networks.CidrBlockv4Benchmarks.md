```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.3959 ns** | **1.6608 ns** | **0.0910 ns** |  **65.2975 ns** |  **65.4772 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0242 ns | 0.0529 ns | 0.0029 ns |   0.0219 ns |   0.0275 ns |         - |
| TryParseCidrString | 1      |  72.4579 ns | 1.0945 ns | 0.0600 ns |  72.4005 ns |  72.5202 ns |         - |
| TryParseCidrBytes  | 1      |   2.7488 ns | 0.0776 ns | 0.0043 ns |   2.7459 ns |   2.7537 ns |         - |
| **NewFromCidrString**  | **3**      | **194.0508 ns** | **1.5211 ns** | **0.0834 ns** | **193.9575 ns** | **194.1179 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6409 ns | 0.1347 ns | 0.0074 ns |   0.6364 ns |   0.6495 ns |         - |
| TryParseCidrString | 3      | 213.6424 ns | 0.8539 ns | 0.0468 ns | 213.5895 ns | 213.6783 ns |         - |
| TryParseCidrBytes  | 3      |   9.2507 ns | 1.7988 ns | 0.0986 ns |   9.1549 ns |   9.3518 ns |         - |
