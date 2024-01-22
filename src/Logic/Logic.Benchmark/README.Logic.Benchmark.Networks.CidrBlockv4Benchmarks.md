```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.3063 ns** |  **0.8577 ns** | **0.0470 ns** |  **65.2655 ns** |  **65.3578 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  73.1573 ns |  5.6102 ns | 0.3075 ns |  72.9240 ns |  73.5057 ns |         - |
| TryParseCidrBytes  | 1      |   3.0603 ns |  0.3273 ns | 0.0179 ns |   3.0402 ns |   3.0748 ns |         - |
| **NewFromCidrString**  | **10**     | **668.1516 ns** | **57.0607 ns** | **3.1277 ns** | **665.6406 ns** | **671.6551 ns** |         **-** |
| NewFromCirBytes    | 10     |   3.3179 ns |  0.5128 ns | 0.0281 ns |   3.2975 ns |   3.3500 ns |         - |
| TryParseCidrString | 10     | 703.2538 ns | 43.8422 ns | 2.4031 ns | 701.1774 ns | 705.8862 ns |         - |
| TryParseCidrBytes  | 10     |  28.7357 ns |  0.5358 ns | 0.0294 ns |  28.7062 ns |  28.7650 ns |         - |
