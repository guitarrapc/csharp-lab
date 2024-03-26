```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.2999 ns** |  **1.6973 ns** | **0.0930 ns** |  **65.2400 ns** |  **65.4070 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  73.6167 ns |  1.0282 ns | 0.0564 ns |  73.5742 ns |  73.6807 ns |         - |
| TryParseCidrBytes  | 1      |   3.0348 ns |  0.0165 ns | 0.0009 ns |   3.0339 ns |   3.0357 ns |         - |
| **NewFromCidrString**  | **3**      | **195.9896 ns** | **10.7045 ns** | **0.5868 ns** | **195.3298 ns** | **196.4528 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6013 ns |  0.0586 ns | 0.0032 ns |   0.5990 ns |   0.6050 ns |         - |
| TryParseCidrString | 3      | 218.1253 ns |  5.7411 ns | 0.3147 ns | 217.8313 ns | 218.4572 ns |         - |
| TryParseCidrBytes  | 3      |   9.0255 ns |  0.9918 ns | 0.0544 ns |   8.9910 ns |   9.0882 ns |         - |
