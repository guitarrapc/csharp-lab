```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.7228 ns** | **5.0977 ns** | **0.2794 ns** |  **65.4038 ns** |  **65.9243 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0625 ns | 0.0636 ns | 0.0035 ns |   0.0595 ns |   0.0664 ns |         - |
| TryParseCidrString | 1      |  74.7475 ns | 2.4152 ns | 0.1324 ns |  74.6244 ns |  74.8875 ns |         - |
| TryParseCidrBytes  | 1      |   2.7698 ns | 0.3305 ns | 0.0181 ns |   2.7592 ns |   2.7907 ns |         - |
| **NewFromCidrString**  | **3**      | **197.5680 ns** | **2.2160 ns** | **0.1215 ns** | **197.4336 ns** | **197.6699 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6436 ns | 0.0292 ns | 0.0016 ns |   0.6421 ns |   0.6453 ns |         - |
| TryParseCidrString | 3      | 209.5878 ns | 0.5932 ns | 0.0325 ns | 209.5631 ns | 209.6247 ns |         - |
| TryParseCidrBytes  | 3      |   9.4392 ns | 2.2623 ns | 0.1240 ns |   9.3634 ns |   9.5823 ns |         - |
