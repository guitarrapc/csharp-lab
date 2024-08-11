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
| **NewFromCidrString**  | **1**      |  **65.0334 ns** |  **1.1719 ns** | **0.0642 ns** |  **64.9594 ns** |  **65.0745 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  73.9873 ns |  3.1491 ns | 0.1726 ns |  73.8444 ns |  74.1791 ns |         - |
| TryParseCidrBytes  | 1      |   3.0357 ns |  0.0404 ns | 0.0022 ns |   3.0343 ns |   3.0383 ns |         - |
| **NewFromCidrString**  | **3**      | **197.8713 ns** | **10.6280 ns** | **0.5826 ns** | **197.3774 ns** | **198.5138 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6013 ns |  0.0645 ns | 0.0035 ns |   0.5989 ns |   0.6053 ns |         - |
| TryParseCidrString | 3      | 219.8773 ns |  7.7009 ns | 0.4221 ns | 219.5778 ns | 220.3601 ns |         - |
| TryParseCidrBytes  | 3      |   9.0056 ns |  2.1003 ns | 0.1151 ns |   8.9285 ns |   9.1379 ns |         - |
