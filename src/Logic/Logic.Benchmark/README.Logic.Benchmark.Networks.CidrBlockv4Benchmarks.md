```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **68.0083 ns** | **19.9844 ns** | **1.0954 ns** |  **67.3611 ns** |  **69.2730 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0231 ns |  0.0577 ns | 0.0032 ns |   0.0209 ns |   0.0267 ns |         - |
| TryParseCidrString | 1      |  73.7051 ns |  2.4594 ns | 0.1348 ns |  73.5532 ns |  73.8103 ns |         - |
| TryParseCidrBytes  | 1      |   2.7468 ns |  0.0785 ns | 0.0043 ns |   2.7435 ns |   2.7517 ns |         - |
| **NewFromCidrString**  | **3**      | **201.6630 ns** |  **1.2354 ns** | **0.0677 ns** | **201.5966 ns** | **201.7320 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6391 ns |  0.0617 ns | 0.0034 ns |   0.6361 ns |   0.6428 ns |         - |
| TryParseCidrString | 3      | 210.9993 ns |  4.0012 ns | 0.2193 ns | 210.8613 ns | 211.2522 ns |         - |
| TryParseCidrBytes  | 3      |   9.2393 ns |  0.8621 ns | 0.0473 ns |   9.1868 ns |   9.2786 ns |         - |
