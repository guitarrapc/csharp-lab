```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.1977 ns** |  **2.9296 ns** | **0.1606 ns** |  **65.0365 ns** |  **65.3577 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  74.1276 ns |  2.8952 ns | 0.1587 ns |  74.0275 ns |  74.3105 ns |         - |
| TryParseCidrBytes  | 1      |   3.0465 ns |  0.1978 ns | 0.0108 ns |   3.0366 ns |   3.0581 ns |         - |
| **NewFromCidrString**  | **3**      | **196.9899 ns** |  **3.0981 ns** | **0.1698 ns** | **196.7962 ns** | **197.1133 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6073 ns |  0.1461 ns | 0.0080 ns |   0.5987 ns |   0.6146 ns |         - |
| TryParseCidrString | 3      | 217.6221 ns | 28.8848 ns | 1.5833 ns | 216.6236 ns | 219.4476 ns |         - |
| TryParseCidrBytes  | 3      |   9.1542 ns |  1.2496 ns | 0.0685 ns |   9.0829 ns |   9.2195 ns |         - |
