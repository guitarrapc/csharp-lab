```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.7923 ns** | **0.5866 ns** | **0.0322 ns** |  **65.7553 ns** |  **65.8137 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0222 ns | 0.0200 ns | 0.0011 ns |   0.0213 ns |   0.0235 ns |         - |
| TryParseCidrString | 1      |  72.4899 ns | 3.1286 ns | 0.1715 ns |  72.3563 ns |  72.6832 ns |         - |
| TryParseCidrBytes  | 1      |   2.7438 ns | 0.0907 ns | 0.0050 ns |   2.7406 ns |   2.7495 ns |         - |
| **NewFromCidrString**  | **3**      | **195.7512 ns** | **7.2142 ns** | **0.3954 ns** | **195.3080 ns** | **196.0679 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6518 ns | 0.1064 ns | 0.0058 ns |   0.6451 ns |   0.6555 ns |         - |
| TryParseCidrString | 3      | 212.8750 ns | 1.2806 ns | 0.0702 ns | 212.7965 ns | 212.9318 ns |         - |
| TryParseCidrBytes  | 3      |   9.2786 ns | 0.7548 ns | 0.0414 ns |   9.2351 ns |   9.3175 ns |         - |
