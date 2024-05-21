```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **68.1577 ns** | **12.6047 ns** | **0.6909 ns** |  **67.7380 ns** |  **68.9551 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  74.1600 ns |  5.4584 ns | 0.2992 ns |  73.8557 ns |  74.4538 ns |         - |
| TryParseCidrBytes  | 1      |   3.0432 ns |  0.2281 ns | 0.0125 ns |   3.0352 ns |   3.0576 ns |         - |
| **NewFromCidrString**  | **3**      | **198.8406 ns** | **42.4152 ns** | **2.3249 ns** | **197.1513 ns** | **201.4922 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6028 ns |  0.0431 ns | 0.0024 ns |   0.6004 ns |   0.6052 ns |         - |
| TryParseCidrString | 3      | 212.6988 ns |  5.9943 ns | 0.3286 ns | 212.3415 ns | 212.9880 ns |         - |
| TryParseCidrBytes  | 3      |   9.0645 ns |  0.6464 ns | 0.0354 ns |   9.0369 ns |   9.1045 ns |         - |
