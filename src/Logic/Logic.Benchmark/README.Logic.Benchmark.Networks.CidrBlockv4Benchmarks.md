```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Median      | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.2994 ns** |  **2.7383 ns** | **0.1501 ns** |  **65.2288 ns** |  **65.1977 ns** |  **65.4718 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0477 ns |  0.7518 ns | 0.0412 ns |   0.0260 ns |   0.0220 ns |   0.0953 ns |         - |
| TryParseCidrString | 1      |  73.9811 ns | 18.9683 ns | 1.0397 ns |  73.3930 ns |  73.3687 ns |  75.1816 ns |         - |
| TryParseCidrBytes  | 1      |   2.7670 ns |  0.1487 ns | 0.0082 ns |   2.7691 ns |   2.7579 ns |   2.7738 ns |         - |
| **NewFromCidrString**  | **3**      | **201.6976 ns** | **81.5435 ns** | **4.4697 ns** | **199.5986 ns** | **198.6637 ns** | **206.8304 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.7411 ns |  2.9556 ns | 0.1620 ns |   0.6485 ns |   0.6466 ns |   0.9281 ns |         - |
| TryParseCidrString | 3      | 212.1789 ns |  9.5635 ns | 0.5242 ns | 212.3660 ns | 211.5868 ns | 212.5839 ns |         - |
| TryParseCidrBytes  | 3      |   9.5197 ns |  0.7903 ns | 0.0433 ns |   9.5121 ns |   9.4806 ns |   9.5663 ns |         - |
