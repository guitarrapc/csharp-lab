```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.2101 ns** | **4.2088 ns** | **0.2307 ns** |  **65.0389 ns** |  **65.4725 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns | 0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  73.2719 ns | 1.1037 ns | 0.0605 ns |  73.2237 ns |  73.3398 ns |         - |
| TryParseCidrBytes  | 1      |   3.0409 ns | 0.2138 ns | 0.0117 ns |   3.0339 ns |   3.0545 ns |         - |
| **NewFromCidrString**  | **3**      | **217.6846 ns** | **8.3061 ns** | **0.4553 ns** | **217.1603 ns** | **217.9793 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6105 ns | 0.0977 ns | 0.0054 ns |   0.6071 ns |   0.6167 ns |         - |
| TryParseCidrString | 3      | 212.1103 ns | 9.8710 ns | 0.5411 ns | 211.6500 ns | 212.7063 ns |         - |
| TryParseCidrBytes  | 3      |   9.0081 ns | 1.5253 ns | 0.0836 ns |   8.9492 ns |   9.1038 ns |         - |
