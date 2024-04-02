```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Median      | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **64.8581 ns** |  **3.4778 ns** | **0.1906 ns** |  **64.8294 ns** |  **64.6834 ns** |  **65.0615 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0021 ns |  0.0668 ns | 0.0037 ns |   0.0000 ns |   0.0000 ns |   0.0063 ns |         - |
| TryParseCidrString | 1      |  74.3433 ns |  3.2729 ns | 0.1794 ns |  74.2467 ns |  74.2329 ns |  74.5503 ns |         - |
| TryParseCidrBytes  | 1      |   3.0740 ns |  0.8709 ns | 0.0477 ns |   3.0578 ns |   3.0366 ns |   3.1278 ns |         - |
| **NewFromCidrString**  | **3**      | **198.9290 ns** | **56.1831 ns** | **3.0796 ns** | **197.5165 ns** | **196.8090 ns** | **202.4614 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6027 ns |  0.1170 ns | 0.0064 ns |   0.6004 ns |   0.5978 ns |   0.6100 ns |         - |
| TryParseCidrString | 3      | 213.5478 ns |  6.4354 ns | 0.3527 ns | 213.3540 ns | 213.3344 ns | 213.9549 ns |         - |
| TryParseCidrBytes  | 3      |   9.1324 ns |  0.3488 ns | 0.0191 ns |   9.1358 ns |   9.1118 ns |   9.1496 ns |         - |
