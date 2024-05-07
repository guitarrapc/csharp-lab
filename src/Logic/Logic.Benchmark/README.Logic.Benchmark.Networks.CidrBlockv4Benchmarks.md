```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.0538 ns** | **2.8366 ns** | **0.1555 ns** |  **64.9418 ns** |  **65.2313 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns | 0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  76.3958 ns | 1.6320 ns | 0.0895 ns |  76.3206 ns |  76.4947 ns |         - |
| TryParseCidrBytes  | 1      |   3.0465 ns | 0.3037 ns | 0.0166 ns |   3.0355 ns |   3.0657 ns |         - |
| **NewFromCidrString**  | **3**      | **201.4255 ns** | **4.0017 ns** | **0.2193 ns** | **201.2038 ns** | **201.6425 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6060 ns | 0.0189 ns | 0.0010 ns |   0.6048 ns |   0.6067 ns |         - |
| TryParseCidrString | 3      | 213.4767 ns | 1.0302 ns | 0.0565 ns | 213.4235 ns | 213.5359 ns |         - |
| TryParseCidrBytes  | 3      |   9.2463 ns | 1.8113 ns | 0.0993 ns |   9.1578 ns |   9.3536 ns |         - |
