```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error       | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|------------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **66.4835 ns** |   **2.2205 ns** | **0.1217 ns** |  **66.3436 ns** |  **66.5651 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |   0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  72.9076 ns |   3.6667 ns | 0.2010 ns |  72.6764 ns |  73.0410 ns |         - |
| TryParseCidrBytes  | 1      |   3.0463 ns |   0.2862 ns | 0.0157 ns |   3.0370 ns |   3.0644 ns |         - |
| **NewFromCidrString**  | **3**      | **200.9261 ns** | **170.0286 ns** | **9.3198 ns** | **195.4299 ns** | **211.6869 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6097 ns |   0.3262 ns | 0.0179 ns |   0.5993 ns |   0.6304 ns |         - |
| TryParseCidrString | 3      | 213.4007 ns |  14.7585 ns | 0.8090 ns | 212.4718 ns | 213.9502 ns |         - |
| TryParseCidrBytes  | 3      |   9.3378 ns |   2.8358 ns | 0.1554 ns |   9.2108 ns |   9.5112 ns |         - |
