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
| **NewFromCidrString**  | **1**      |  **67.1207 ns** |  **4.3487 ns** | **0.2384 ns** |  **66.9205 ns** |  **67.3844 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  74.1346 ns |  4.0345 ns | 0.2211 ns |  73.9519 ns |  74.3805 ns |         - |
| TryParseCidrBytes  | 1      |   3.0436 ns |  0.2117 ns | 0.0116 ns |   3.0366 ns |   3.0570 ns |         - |
| **NewFromCidrString**  | **3**      | **197.6233 ns** | **47.2325 ns** | **2.5890 ns** | **195.9188 ns** | **200.6025 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6090 ns |  0.1508 ns | 0.0083 ns |   0.6003 ns |   0.6168 ns |         - |
| TryParseCidrString | 3      | 215.5767 ns | 26.3922 ns | 1.4466 ns | 214.2510 ns | 217.1197 ns |         - |
| TryParseCidrBytes  | 3      |   9.1718 ns |  0.2389 ns | 0.0131 ns |   9.1572 ns |   9.1824 ns |         - |
