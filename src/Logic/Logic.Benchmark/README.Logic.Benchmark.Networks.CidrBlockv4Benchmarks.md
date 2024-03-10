```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.4930 ns** | **6.2054 ns** | **0.3401 ns** |  **65.2961 ns** |  **65.8857 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns | 0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  73.7774 ns | 8.0697 ns | 0.4423 ns |  73.4925 ns |  74.2870 ns |         - |
| TryParseCidrBytes  | 1      |   3.0518 ns | 0.2822 ns | 0.0155 ns |   3.0359 ns |   3.0668 ns |         - |
| **NewFromCidrString**  | **3**      | **194.9725 ns** | **4.3117 ns** | **0.2363 ns** | **194.6996 ns** | **195.1101 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6698 ns | 2.2056 ns | 0.1209 ns |   0.5994 ns |   0.8094 ns |         - |
| TryParseCidrString | 3      | 212.2066 ns | 8.2690 ns | 0.4533 ns | 211.9381 ns | 212.7299 ns |         - |
| TryParseCidrBytes  | 3      |   8.7322 ns | 0.5371 ns | 0.0294 ns |   8.6983 ns |   8.7517 ns |         - |
